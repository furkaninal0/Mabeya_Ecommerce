using MabeyaECommerce.Domain;
using MabeyaECommerce.Migrations;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Ocsp;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;
using System.Net.NetworkInformation;
using System.Threading.Tasks;

namespace MabeyaECommerce.Areas.Admin.Controllers;

[Area("Admin")]
[Authorize(Roles = "Administrators")]
public class ProductsController(
    MabeyaDbContext dbContext
    ) : Controller
{
    public async Task<IActionResult> Index()
    {
        var items = await dbContext.Products.OrderBy(p => p.Name).ToListAsync();
        return View(items);
    }

    public IActionResult Create()
    {
        return View(new Product { });
    }
    [HttpPost]
    public async Task<IActionResult> Create(Product model)
    {
        model.CreatedAt = DateTime.Now;
        var form = Request.Form;
        var specs = await dbContext.Specs.ToListAsync();

        specs
            .Where(p => !string.IsNullOrEmpty(form[p.Id.ToString()]))
            .ToList()
            .ForEach(p =>
            {
                model.ProductDetails.Add(new ProductDetails
                {
                    specId = p.Id,
                    Value = form[p.Id.ToString()]
                });

            });
        var allowedTypes = new[] { "image/jpeg", "image/png", "image/webp", "image/gif", "image/bmp" };
        if (model.ImageFile is not null && model.ImageFile.Length > 0)
        {
            if (!allowedTypes.Contains(model.ImageFile.ContentType))
            {
                ModelState.AddModelError("ImageFile", "Desteklenmeyen resim formatı(yalnızca JPG, PNG, WEBP, GIF, BMP).");
                return View(model);
            }

            try
            {
                using var image = await Image.LoadAsync(model.ImageFile.OpenReadStream());
                image.Mutate(p =>
                {
                    p.Resize(new ResizeOptions
                    {
                        Size = new Size(800, 600),
                        Mode = ResizeMode.BoxPad
                    });
                });
                using var ms = new MemoryStream();
                await image.SaveAsWebpAsync(ms);
                model.Image = ms.ToArray();
            }
            catch (UnknownImageFormatException)
            {
                ModelState.AddModelError("ImageFile", "Geçersiz veya bozuk resim formatı yüklendi.");
                return View(model);
            }
        }
        if (model.ImageFiles is not null)
        {
            foreach (var file in model.ImageFiles)
            {
                if (file.Length == 0 || !allowedTypes.Contains(file.ContentType))
                    continue;
                try
                {
                    using var image = await Image.LoadAsync(file.OpenReadStream());
                    image.Mutate(p =>
                    {
                        p.Resize(new ResizeOptions
                        {
                            Size = new Size(800, 600),
                            Mode = ResizeMode.BoxPad

                        });
                    });
                    using var ms = new MemoryStream();
                    await image.SaveAsWebpAsync(ms);
                    model.ProductImages.Add(new ProductImages
                    {
                        IsEnabled = true,
                        CreatedAt = DateTime.UtcNow,
                        Image = ms.ToArray()
                    });
                }
                catch (UnknownImageFormatException)
                {
                    continue;
                }
            }
        }
        if (model.SelectedProducts is not null)
            model.SelectedProducts.ToList().ForEach(p => model.Catalogs.Add(dbContext.Catalogs.Find(p)));

        dbContext.Add(model);
        await dbContext.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }
    public async Task<IActionResult> Edit(Guid id)
    {
        var item = await dbContext.Products.Include(p => p.Catalogs).Include(p => p.ProductDetails).Include(p => p.ProductImages).AsNoTracking().SingleOrDefaultAsync(p => p.Id == id);
        return View(item);
    }
    [HttpPost]
    public async Task<IActionResult> Edit(Product model)
    {
        var item = await dbContext.Products.Include(p => p.Catalogs).Include(p => p.ProductDetails).Include(p => p.ProductImages).SingleOrDefaultAsync(p => p.Id == model.Id);

        if (item == null)
            return NotFound();
        
        item.Name = model.Name;
        item.Description = model.Description;
        item.Category = model.Category;
        item.Price = model.Price;
        item.IsEnabled = model.IsEnabled;
      
        if (model.CategoryId != Guid.Empty)
            item.CategoryId = model.CategoryId;
       
        var form = Request.Form;
        dbContext.ProductDetails.RemoveRange(item.ProductDetails);

        var details = await dbContext.Specs.ToListAsync();
        
        foreach (var detail in details)
        {
            var value = form[detail.Id.ToString()];

            if (!string.IsNullOrEmpty(value))
            {

                item.ProductDetails.Add(new ProductDetails
                {
                    specId = detail.Id,
                    Value = value
                });

            }

        }
                

        var allowedTypes = new[] { "image/jpeg", "image/png", "image/webp", "image/gif", "image/bmp" };
        if (model.ImageFile != null && model.ImageFile.Length > 0)
            if (!allowedTypes.Contains(model.ImageFile.ContentType))
            {
                ModelState.AddModelError("ImageFile", "Desteklenmeyen resim formatı (yalnızca JPG, PNG, WEBP, GIF, BMP).");
                return View(item);
        try
        {
            using var image = await Image.LoadAsync(model.ImageFile.OpenReadStream());
            image.Mutate(p =>
            {
                p.Resize(new ResizeOptions
                {
                    Size = new Size(1500, 1250),
                    Mode = ResizeMode.Crop
                });
            });
            using var ms = new MemoryStream();
            await image.SaveAsWebpAsync(ms);
            item.Image = ms.ToArray();
        }
        catch (UnknownImageFormatException)
        {
            ModelState.AddModelError("ImageFile", "Geçersiz veya bozuk resim formatı yüklendi.");
            return View(item);

        }
            }

        if (model.ImageFiles != null && model.ImageFiles.Any())
        {
            foreach (var file in model.ImageFiles)
            {
                if (file.Length == 0 || !allowedTypes.Contains(file.ContentType))
                    continue;

                try
                {
                    using var image = await Image.LoadAsync(file.OpenReadStream());
                    image.Mutate(p =>
                    {
                        p.Resize(new ResizeOptions
                        {
                            Size = new Size(1500, 1250),
                            Mode = ResizeMode.Crop
                        });
                    });
                    using var ms = new MemoryStream();
                    await image.SaveAsWebpAsync(ms);
                    item.ProductImages.Add(new ProductImages
                    {
                        IsEnabled = true,
                        CreatedAt = DateTime.Now,
                        Image = ms.ToArray()
                    });
                }
                catch (UnknownImageFormatException)
                {
                    continue;
                }
            }
        }
        item.Catalogs.Clear();
        if (model.SelectedCatalogs is not null && model.SelectedCatalogs.Any())
        {
            var catalogsToAdd = await dbContext.Catalogs.Where(p => model.SelectedCatalogs.Contains(p.Id)).ToListAsync();
            foreach (var catalog in catalogsToAdd)
            {
                item.Catalogs.Add(catalog);
            }
        }
        await dbContext.SaveChangesAsync();
        return RedirectToAction(nameof(Index));

    }
    public async Task<IActionResult> Delete(Guid id)
    {
        var item = await dbContext.Products.Include(p => p.ProductImages).SingleOrDefaultAsync(p => p.Id == id);
        if (item != null)
        {
            dbContext.ProductImages.RemoveRange(item.ProductImages);
            dbContext.Products.Remove(item);

            await dbContext.SaveChangesAsync();
        }
        return RedirectToAction(nameof(Index));
    }
}



using MabeyaECommerce.Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Ocsp;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;

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
                model.Prodc_Details.Add(new ProductDetails
                {
                    specId = p.Id,
                    Value = form[p.Id.ToString()]
                });

            });
            var allowedTypes = new[] {"image/jpeg", "image/png", "image/webp", "image/gif", "image/bmp" };
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
            catch(UnknownImageFormatException)
            {
                ModelState.AddModelError("ImageFile", "Geçersiz veya bozuk resim formatı yüklendi.");
                return View(model);
            }
        }
        if (model.ImageFiles is not null)
        {
            foreach (var file in model.ImageFiles) 
            {
                if(file.Length == 0 || !allowedTypes.Contains(file.ContentType))
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
                    model.ProductImagess.Add(new ProductImages
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

}

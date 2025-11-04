using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MabeyaECommerce.Areas.Admin.Models;
using MabeyaECommerce.Domain;
using System.Threading.Tasks;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;
using Microsoft.EntityFrameworkCore;


namespace MabeyaECommerce.Areas.Admin.Controllers;
[Area("Admin")]
[Authorize(Roles = "Administrators")]
public class SliderImagesController (
    MabeyaDbContext dbContext
    ): Controller
{
    public async Task<IActionResult> Index()
    {
        var items = await dbContext.sliderImages.Select(p => new SliderImagesDto
        {
            Id = p.Id,
            Url = p.Url,
            CreatedAt = p.CreatedAt,
            IsEnabled = p.IsEnabled,
            catalogId = p.catalogId,
        }).ToListAsync();
        return View(items);


    }
    public IActionResult Create()
    {

        return View(new SliderImagesDto {IsEnabled = true });
    }
    [HttpPost]
    public async Task<IActionResult> Create(SliderImagesDto model)
    {
        var item = new SliderImage();

        item.Url = model.Url;
        item.CreatedAt = DateTime.UtcNow;
        item.IsEnabled = model.IsEnabled;
        item.catalogId = model.catalogId;

        if (model.ImageFile is not null)
        {
            using var image = await Image.LoadAsync(model.ImageFile.OpenReadStream());
            image.Mutate(async p =>
            {
                p.Resize(new ResizeOptions
                {
                    Size = new Size(1200, 400),
                    Mode = ResizeMode.Crop,
                });
                using var ms = new MemoryStream();
                await image.SaveAsWebpAsync(ms);
                item.Image = ms.ToArray();
            });
        }

        dbContext.Add(item);
        await dbContext.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }
    public async Task<IActionResult> Edit(Guid id)
    {
        var item = await dbContext.sliderImages.FirstOrDefaultAsync(p => p.Id == id);
        return View(new SliderImagesDto
        {
            Id = item.Id,
            Url = item.Url,
            IsEnabled = item.IsEnabled,
            catalogId = item.catalogId,

        });
    }
    [HttpPost]
    public async Task<IActionResult> Edit(SliderImagesDto model) 
    {
        var item = await dbContext.sliderImages.SingleOrDefaultAsync(p=>p.Id == model.Id);
        
        item.Url = model.Url;
        item.IsEnabled = model.IsEnabled;
        item.catalogId = model.catalogId;

        if (model.ImageFile is not null)
        {
            using var image = await Image.LoadAsync(model.ImageFile.OpenReadStream());
            image.Mutate(async p =>
            {
                p.Resize(new ResizeOptions
                {
                    Size = new Size(1280, 400),
                    Mode = ResizeMode.Crop,
                });
                using var ms = new MemoryStream();
                await image.SaveAsWebpAsync(ms);
                item.Image = ms.ToArray();
            });
        }
        dbContext.Update(item);
        await dbContext.SaveChangesAsync();

        return RedirectToAction(nameof(Index));
    }
    public async Task<IActionResult> Delete(Guid id)
    {
        var item = await dbContext.sliderImages.SingleOrDefaultAsync(p => p.Id == id);
        dbContext.Remove(item);
        await dbContext.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }









}

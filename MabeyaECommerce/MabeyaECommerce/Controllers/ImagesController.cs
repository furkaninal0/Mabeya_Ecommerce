using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OutputCaching;
using System.Threading.Tasks;

namespace MabeyaECommerce.Controllers;

public class ImagesController(
    MabeyaDbContext dbContext
    ) : Controller
{
    [OutputCache(Duration = 86400)]
    public async Task<IActionResult> Product(Guid id)
    {
        var item = await dbContext.Products.FindAsync(id);
        if (item == null)
        {
            return NotFound("Ürün Bulunamadı!");
        }
        if (item.Image == null)
        {
            var defaultImagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/noimage2.png");
            var defaultImage = await System.IO.File.ReadAllBytesAsync(defaultImagePath);
            return File(defaultImage , "image/webp");
        }
        return File(item.Image , "image/webp");
    }
    [OutputCache(Duration = 86400)]
    public async Task<IActionResult> SliderImage(Guid id)
    {
        var item = await dbContext.sliderImages.FindAsync(id);
        return File(item.Image, "image/webp");
    }
    [OutputCache(Duration = 86400)]

    public async Task<IActionResult> ProductImage(Guid id)
    {
        var item = await dbContext.ProductImages.FindAsync(id);
        return File(item.Image, "image/webp");
    }

}

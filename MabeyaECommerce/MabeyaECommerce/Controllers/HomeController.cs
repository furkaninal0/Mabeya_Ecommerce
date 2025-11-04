using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using MabeyaECommerce.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MabeyaECommerce.Controllers;

public class HomeController (
    MabeyaDbContext dbContext
    ): Controller
{
    public IActionResult Index()
    {
        return View();
    }
    public async Task<IActionResult> Search(string keyword)
    {
        if (string.IsNullOrWhiteSpace(keyword))
        {
            return View(new List<ProductTileViewModel>()); // boþ liste döner
        }

        var upperKeyword = keyword.ToUpper();
        var keywords = keyword.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                          .Select(k => k.ToUpper()) // Her kelimeyi büyüt
                          .ToList();

        var model = (await dbContext.Products
            .Where(p => p.IsEnabled)
            .Where(p => keywords.Any(k => p.Name!.ToUpper().Contains(k)))
            .Include(p => p.Category)
            .Select(p => new ProductTileViewModel
            {
                Id = p.Id,
                Name = p.Name!,
                Price = p.Price,
                CategoryId = p.CategoryId,
                CategoryName = p.Category!.Name!
            }).ToListAsync());
            return View(model);

    }
    public async Task<IActionResult> Category(Guid id)
    {
        var model = await dbContext.Categories
            .Include(p => p.Products)
            .SingleOrDefaultAsync(p => p.Id == id);
        return View(model);

    }
   public async Task<IActionResult> Catalog(Guid id)
    {
        var model = await dbContext.Catalogs
            .Include(p => p.Products).ThenInclude(p => p.Category)
            .SingleOrDefaultAsync(p => p.Id == id);
        return View(model);

    }
    public IActionResult Detail(Guid id)
    {
        var model = dbContext.Products
        .Include(p => p.Category)
        .Include(p => p.Catalogs)
        .Include(p => p.ProductDetails).ThenInclude(pd => pd.Spec)
        .Include(p => p.ProductImages)
        .SingleOrDefault(p => p.Id == id);

        if(model is null)
        {
            return NotFound();
        }
        return View(model);

    }
}

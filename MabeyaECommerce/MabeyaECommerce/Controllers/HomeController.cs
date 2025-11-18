using MabeyaECommerce.Domain;
using MabeyaECommerce.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

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
            return View(new List<ProductTileViewModel>());
        }

        var upperKeyword = keyword.ToUpper();
        var keywords = keyword.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                          .Select(k => k.ToUpper()) 
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
         .Include(c => c.Products)
             .ThenInclude(p => p.ProductDetails)
                 .ThenInclude(d => d.Spec)
         .SingleOrDefaultAsync(c => c.Id == id);
        return View(model);

    }
   public async Task<IActionResult> Catalog(Guid id)
    {
        var model = await dbContext.Catalogs
            .Include(p => p.Products).ThenInclude(p => p.Category)
            .SingleOrDefaultAsync(p => p.Id == id);
        return View(model);

    }
    public async Task<IActionResult> Detail(Guid id)
    {
        var product = await dbContext.Products
         .Include(p => p.ProductImages)
         .Include(p => p.Category)
         .Include(p => p.ProductDetails)
             .ThenInclude(pd => pd.Spec)
         .Include(p => p.Comments)
             .ThenInclude(c => c.User)
         .SingleOrDefaultAsync(p => p.Id == id);
        if (product == null) return NotFound();

        var relatedProducts = await dbContext.Products
            .Where(p => p.CategoryId == product.CategoryId && p.Id != product.Id && p.IsEnabled)
            .OrderByDescending(p => p.CreatedAt)
            .Take(6)
            .ToListAsync();

        ViewBag.Related = relatedProducts;

        return View(product);

    }
    [HttpGet]
    [HttpGet]
    public async Task<IActionResult> FilterProducts(
    Guid catalogId,
    int? minPrice,
    int? maxPrice,
    string sort)
    {
        var products = dbContext.Products
            .Include(p => p.ProductImages)
            .Include(p => p.Category)
            .Include(p => p.Catalogs)
            .Where(p => p.Catalogs.Any(c => c.Id == catalogId) && p.IsEnabled);

        if (minPrice.HasValue)
            products = products.Where(p => p.Price >= minPrice.Value);

        if (maxPrice.HasValue)
            products = products.Where(p => p.Price <= maxPrice.Value);

        products = sort switch
        {
            "asc" => products.OrderBy(p => p.Price),
            "desc" => products.OrderByDescending(p => p.Price),
            "new" => products.OrderByDescending(p => p.CreatedAt),
            _ => products
        };

        var list = await products
            .Select(p => new ProductTileViewModel
            {
                Id = p.Id,
                Name = p.Name!,
                Price = p.Price,
                CategoryId = p.CategoryId,
                CategoryName = p.Category!.Name!
            })
            .ToListAsync();

        return PartialView("_ProductListPartial", list);
    }
    [HttpGet]
    public async Task<IActionResult> FilterCatalogProducts(
    Guid catalogId,
    int? minPrice,
    int? maxPrice,
    string sort)
    {
        var products = dbContext.Products
            .Include(p => p.ProductImages)
            .Include(p => p.Category)
            .Include(p => p.Catalogs)
            .Where(p => p.Catalogs.Any(c => c.Id == catalogId) && p.IsEnabled);

        if (minPrice.HasValue)
            products = products.Where(p => p.Price >= minPrice.Value);

        if (maxPrice.HasValue)
            products = products.Where(p => p.Price <= maxPrice.Value);

        products = sort switch
        {
            "asc" => products.OrderBy(p => p.Price),
            "desc" => products.OrderByDescending(p => p.Price),
            "new" => products.OrderByDescending(p => p.CreatedAt),
            _ => products
        };

        var list = await products
            .Select(p => new ProductTileViewModel
            {
                Id = p.Id,
                Name = p.Name!,
                Price = p.Price,
                CategoryId = p.CategoryId,
                CategoryName = p.Category!.Name!
            })
            .ToListAsync();

        return PartialView("_ProductListPartial", list);
    }


    [HttpGet]
    public async Task<IActionResult> FilterCategoryProducts(
    Guid categoryId,
    string spec,
    string value,
    int? minPrice,
    int? maxPrice,
    string sort)
    {
        var products = dbContext.Products
            .Include(p => p.ProductDetails)
                .ThenInclude(d => d.Spec)
            .Include(p => p.Category)
            .Where(p => p.CategoryId == categoryId && p.IsEnabled);

        if (!string.IsNullOrEmpty(spec) && !string.IsNullOrEmpty(value))
        {
            products = products.Where(p =>
                p.ProductDetails.Any(d => d.Spec.Name == spec && d.Value == value));
        }

        if (minPrice.HasValue)
            products = products.Where(p => p.Price >= minPrice.Value);

        if (maxPrice.HasValue)
            products = products.Where(p => p.Price <= maxPrice.Value);

        products = sort switch
        {
            "asc" => products.OrderBy(p => p.Price),
            "desc" => products.OrderByDescending(p => p.Price),
            "new" => products.OrderByDescending(p => p.CreatedAt),
            _ => products
        };

        var list = await products
            .Select(p => new ProductTileViewModel
            {
                Id = p.Id,
                Name = p.Name!,
                Price = p.Price,
                CategoryId = p.CategoryId,
                CategoryName = p.Category!.Name!
            })
            .ToListAsync();

        return PartialView("_ProductListPartial", list);
    }
}

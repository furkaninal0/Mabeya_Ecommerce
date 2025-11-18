using MabeyaECommerce.Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace MabeyaECommerce.Areas.Admin.Controllers;
[Area("Admin")]
[Authorize(Roles = "Administrators")]
public class CategoriesController (
    MabeyaDbContext dbContext
    ): Controller
{
    public async Task<IActionResult> Index()
    {
        var items = await dbContext.Categories.OrderBy(p=>p.Name).ToListAsync();
        return View(items);
    }
    public IActionResult Create()
    {
        return View( new Category { });
    }
    [HttpPost]
    public async Task<IActionResult> Create(Category model)
    {
        model.CreatedAt = DateTime.Now;
        dbContext.Add(model);
        await dbContext.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }
    public async Task<IActionResult> Edit(Guid id)
    {
        var item = await dbContext.Categories.FirstOrDefaultAsync(p=>p.Id == id);
        return View(item);
    }
    [HttpPost]
    public async Task<IActionResult> Edit(Category model)
    {
        var item = await dbContext.Categories.SingleOrDefaultAsync(p=>p.Id == model.Id);

        item.Name = model.Name;
        item.IsEnabled = model.IsEnabled;

        dbContext.Update(item);
        await dbContext.SaveChangesAsync();

        return RedirectToAction(nameof(Index));

    }
    public async Task<IActionResult> Delete(Guid id)
    {
        var item = await dbContext.Categories
                        .Include(c => c.Products) 
                        .FirstOrDefaultAsync(p => p.Id == id);

        if (item == null)
            return NotFound();

        if (item.Products.Any())
        {
            TempData["Error"] = "Bu kategori ürün içeriyor. Silinemez!";
            return RedirectToAction(nameof(Index));
        }

        dbContext.Categories.Remove(item);
        await dbContext.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

}

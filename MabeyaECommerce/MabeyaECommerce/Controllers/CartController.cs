using MabeyaECommerce.Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace MabeyaECommerce.Controllers;

[Authorize]
public class CartController (MabeyaDbContext dbContext) : Controller
{
   


    [HttpPost]
    [HttpGet]
    public async Task<IActionResult> Add(Guid id)
    {
        var userId = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
        var product = await dbContext.Products.SingleOrDefaultAsync(p => p.Id == id);

        if (product == null)
        {
            TempData["error"] = "Ürün bulunamadı!";
            return RedirectToAction("Index", "Home");
        }

        var item = await dbContext.shoppingCartItems
            .SingleOrDefaultAsync(p => p.UserId == userId && p.ProductId == id);

        if (item == null)
        {
            item = new ShoppingCartItem
            {
                ProductId = id,
                UserId = userId,
                Quantity = 1
            };
            dbContext.shoppingCartItems.Add(item);
        }
        else
        {
            item.Quantity++;
            dbContext.shoppingCartItems.Update(item);
        }

        await dbContext.SaveChangesAsync();
        TempData["success"] = "Ürün sepete eklendi.";
        var referer = Request.Headers["Referer"].ToString();
        if (string.IsNullOrEmpty(referer) ||
           referer.Contains("/Account/Login", StringComparison.OrdinalIgnoreCase))
        {
            return RedirectToAction("Index", "Home");
        }

        return Redirect(referer);
    }
}
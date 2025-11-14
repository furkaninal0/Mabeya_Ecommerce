using MabeyaECommerce.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace MabeyaECommerce.Controllers;

public class ProfileController (MabeyaDbContext dbContext): Controller
{
  
    public async Task<IActionResult> Profile()
    {
        var userıd = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);

        var user = dbContext.Users.FirstOrDefault(p => p.Id == userıd);
        if (user == null)
        {
            return NotFound();
        }

        return View(user);
    }
    public IActionResult Index()
    {
        return View();
    }
    public async Task<IActionResult> PastOrders()
    {
        ViewData["Title"] = "Tamamlanmış Siparişler";

        var model = await dbContext.shoppedOrders
            .Include(p => p.User)
            .Include(p => p.Order_Items)
            .ThenInclude(p => p.Product)
            .OrderByDescending(p => p.Date)
            .Where(p => p.Status == OrderStatus.Shipped)
            .ToListAsync();
        return View("Index" , model);
    }



}

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NETCore.MailKit.Core;
using System.Threading.Tasks;

namespace MabeyaECommerce.Areas.Admin.Controllers;
[Area("Admin")]
[Authorize(Roles = "Administrators ")]
public class ShoppedOrdersController(MabeyaDbContext dbContext , IEmailService emailService) : Controller
{
    public async Task<IActionResult> Index()
    {
        ViewData["Title"] = "Yeni Siparişler";
        var model = await dbContext.shoppedOrders
            .Include(p=>p.User)
            .Include(p => p.Order_Items)
            .ThenInclude(p => p.Product)
            .OrderBy(p=>p.Date)
            .Where(p=>p.Status == Domain.OrderStatus.New)
            .ToListAsync();
        return View(model);

    }
    public async Task<IActionResult> InProgess()
    {
        ViewData["Title"] = "Aktif Siparişler";

        var model = await dbContext
           .shoppedOrders
           .Include(p => p.User)
           .Include(p => p.Order_Items)
           .ThenInclude(p => p.Product)
           .OrderBy(p => p.Date)
           .Where(p => p.Status == Domain.OrderStatus.InProgress)
           .ToListAsync();
        return View("Index", model);
    }
    public async Task<IActionResult> Detail(Guid id)
    {
        var model = await dbContext.shoppedOrders
            .Include(p => p.User)
            .Include(p=>p.Order_Items)
            .ThenInclude(p=>p.Product)
            .SingleOrDefaultAsync(p=>p.Id  == id);
        return View(model);
    }
    public async Task<IActionResult> ToInProgress(Guid id)
    {
        var model = await dbContext.shoppedOrders
            .Include(p => p.User)
            .SingleOrDefaultAsync(p => p.Id == id);

        model.Status = Domain.OrderStatus.InProgress;
        dbContext.SaveChanges();
        await dbContext.SaveChangesAsync();

        var body = $@"<h4> Merhabalar Sn. {model.User!.givenName} </h4><p>Siparişiniz Hazırlanıyor</p>";

        await emailService.SendAsync(
            model.User.Email,
            "Siparişiniz Hakkında",
            body,
            true
            );

        return RedirectToAction(nameof(Index));

    }
    public async Task<IActionResult> ToShipped(Guid id)
    {
        var model = await dbContext.shoppedOrders
            .Include(p=>p.User)
            .SingleOrDefaultAsync(p=>p.Id == id);

        model.Status= Domain.OrderStatus.Shipped; 
        dbContext.Update(model);
        await dbContext.SaveChangesAsync();
            var body = $@"<h4> Merhabalar Sn. {model.User!.givenName} </h4><p>Siparişiniz yola çıkmıştır</p>";

        await emailService.SendAsync(
            model.User.Email,
            "Siparişiniz Hakkında",
            body,
            true
            );
        return RedirectToAction(nameof(Index));

    }


}

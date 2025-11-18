using MabeyaECommerce.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MabeyaECommerce.Controllers;

public class ProfileController (MabeyaDbContext dbContext): Controller
{

    public async Task<IActionResult> Profile()
    {
        var userId = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
        var orders = dbContext.shoppedOrders
            .Include(p => p.Order_Items)
                .ThenInclude(p => p.Product)
            .Where(p => p.UserId == userId && p.Status != OrderStatus.Delivered)
            .OrderByDescending(p => p.Date)
            .ToList();

        var user = dbContext.Users.Find(userId);

        ViewBag.Title = "Devam Eden Siparişler";
        ViewBag.Orders = orders;

        return View(user);
    }
    public async Task<IActionResult> PastOrders()
    {
        var userId = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);

        var user = await dbContext.Users.FirstOrDefaultAsync(p => p.Id == userId);

        var allOrders = await GetOrders(userId);

        ViewBag.Title = "Tamamlanmış Siparişler";
        ViewBag.Orders = allOrders
            .Where(p => p.Status == OrderStatus.Delivered || p.Status == OrderStatus.Cancelled)
            .ToList();

        return View("Profile", user);
    }
    [HttpPost]
    public async Task<IActionResult> CancelOrder(Guid id)
    {
        var order = await dbContext.shoppedOrders
            .Include(p => p.User)
            .FirstOrDefaultAsync(p => p.Id == id);

        if (order == null) return NotFound();

        // Kullanıcı sadece New veya InProgress olanları iptal edebilir
        if (order.Status != OrderStatus.New && order.Status != OrderStatus.InProgress)
            return BadRequest("Bu sipariş iptal edilemez.");

        order.Status = OrderStatus.Cancelled;
        await dbContext.SaveChangesAsync();

        return RedirectToAction("PastOrders", "Profile");
    }
    public IActionResult RequestReturn(Guid id)
    {
        var order = dbContext.shoppedOrders.FirstOrDefault(p => p.Id == id);

        if (order == null) return NotFound();

        if (order.Status != OrderStatus.Delivered)
            return BadRequest("Bu siparişte iade talebi oluşturulamaz.");

        order.IsReturnRequested = true;

        dbContext.SaveChanges();

        TempData["success"] = "İade talebiniz alınmıştır.";
        return RedirectToAction("PastOrders", "Profile");
    }
    [HttpPost]
    public async Task<IActionResult> SendReturnCargo(Guid id, string userReturnTracking)
    {
        var userId = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);

        var order = await dbContext.shoppedOrders
            .FirstOrDefaultAsync(p => p.Id == id && p.UserId == userId);

        if (order == null) return NotFound();

        if (!order.IsReturnApproved)
            return BadRequest("Bu sipariş için iade onayı verilmemiş.");

        order.UserReturnTrackingNumber = userReturnTracking;
        await dbContext.SaveChangesAsync();

        TempData["success"] = "İade kargonuz sisteme kaydedildi.";
        return RedirectToAction("PastOrders");
    }
    public async Task<IActionResult> Adresses ()
    {
        var userId = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);

        var user = await dbContext.Users.FirstOrDefaultAsync(p => p.Id == userId);

        ViewBag.Orders = await GetOrders(userId); 

        var addresses = await dbContext.Addresses
     .Include(a => a.City).ThenInclude(c => c.Province)
     .Where(a => a.UserId == userId)
     .OrderByDescending(a => a.CreatedAt)
     .ToListAsync();

        ViewBag.Title = "Adreslerim";
        ViewBag.ShippingAddresses = addresses.Where(a => a.IsShipping).ToList();
        ViewBag.PersonalBillingAddresses = addresses.Where(a => a.IsInvoice && string.IsNullOrEmpty(a.TaxNumber)).ToList();
        ViewBag.CorporateBillingAddresses = addresses.Where(a => a.IsInvoice && !string.IsNullOrEmpty(a.TaxNumber)).ToList();

        return View("Profile", user);
    }
    private async Task<List<ShoppedOrder>> GetOrders(Guid userId)
    {
        return await dbContext.shoppedOrders
            .Include(p => p.Order_Items).ThenInclude(p => p.Product)
            .Where(p => p.UserId == userId)
            .OrderByDescending(p => p.Date)
            .ToListAsync();
    }
    [HttpPost]
    public async Task<IActionResult> DeleteAddress(Guid id)
    {
        var address = await dbContext.Addresses.FindAsync(id);

        if (address == null)
            return NotFound();

        address.IsDeleted = true;
        await dbContext.SaveChangesAsync();

        TempData["success"] = "Adres başarıyla silindi.";

        return RedirectToAction("Adresses");
    }
    public async Task<IActionResult> EditAddress(Guid id)
    {
        var userId = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);

        var address = await dbContext.Addresses
            .Include(a => a.City).ThenInclude(c => c.Province)
            .FirstOrDefaultAsync(a => a.Id == id && a.UserId == userId);

        if (address == null)
            return NotFound();

        ViewBag.Provinces = await dbContext.Provinces.OrderBy(p => p.Name).ToListAsync();
        ViewBag.Cities = await dbContext.Cities.OrderBy(c => c.Name).ToListAsync();

        return View(address);
    }


    [HttpPost]
    public async Task<IActionResult> EditAddress(Address model)
    {
        var userId = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);

        var address = await dbContext.Addresses
            .FirstOrDefaultAsync(a => a.Id == model.Id && a.UserId == userId);

        if (address == null)
            return NotFound();

        address.Name = model.Name;
        address.Number = model.Number;
        address.Text = model.Text;
        address.CityId = model.CityId;
        address.IsShipping = model.IsShipping;
        address.IsInvoice = model.IsInvoice;
        address.TaxNumber = model.TaxNumber;
        address.TaxOffice = model.TaxOffice;
        address.Name = model.Name;

        await dbContext.SaveChangesAsync();

        TempData["success"] = "Adres başarıyla güncellendi.";
        return RedirectToAction("Adresses");
    }

}

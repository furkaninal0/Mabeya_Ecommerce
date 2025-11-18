using MabeyaECommerce.Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NETCore.MailKit.Core;
using System.Threading.Tasks;

namespace MabeyaECommerce.Areas.Admin.Controllers;
[Area("Admin")]
[Authorize(Roles = "Administrators ")]
public class ShoppedOrdersController(MabeyaDbContext dbContext, IEmailService emailService) : Controller
{
    public async Task<IActionResult> Index()
    {
        ViewData["Title"] = "Yeni Siparişler";
        var model = await dbContext.shoppedOrders
            .Include(p => p.User)
            .Include(p => p.Order_Items)
            .ThenInclude(p => p.Product)
            .OrderBy(p => p.Date)
            .Where(p => p.Status == Domain.OrderStatus.New)
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
    public async Task<IActionResult> Shipped()
    {
        ViewData["Title"] = "Aktif Siparişler";

        var model = await dbContext
           .shoppedOrders
           .Include(p => p.User)
           .Include(p => p.Order_Items)
           .ThenInclude(p => p.Product)
           .OrderBy(p => p.Date)
           .Where(p => p.Status == Domain.OrderStatus.Shipped)
           .ToListAsync();
        return View("Index", model);
    }
    public async Task<IActionResult> Delivered()
    {
        ViewData["Title"] = "Aktif Siparişler";

        var model = await dbContext
           .shoppedOrders
           .Include(p => p.User)
           .Include(p => p.Order_Items)
           .ThenInclude(p => p.Product)
           .OrderBy(p => p.Date)
           .Where(p => p.Status == Domain.OrderStatus.Delivered)
           .ToListAsync();

        return View("Index", model);
    }
    public async Task<IActionResult> Cancalled()
    {
        ViewData["Title"] = "Aktif Siparişler";

        var model = await dbContext
           .shoppedOrders
           .Include(p => p.User)
           .Include(p => p.Order_Items)
           .ThenInclude(p => p.Product)
           .OrderBy(p => p.Date)
           .Where(p => p.Status == Domain.OrderStatus.Cancelled)
           .ToListAsync();
        return View("Index", model);
    }

    public async Task<IActionResult> Detail(Guid id)
    {
        var model = await dbContext.shoppedOrders
            .Include(p => p.User)
            .Include(p => p.Order_Items)
            .ThenInclude(p => p.Product)
            .SingleOrDefaultAsync(p => p.Id == id);
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
            .Include(p => p.User)
            .SingleOrDefaultAsync(p => p.Id == id);

        model.Status = Domain.OrderStatus.Shipped;
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
    public async Task<IActionResult> ToDelivered(Guid id)
    {
        var model = await dbContext.shoppedOrders
            .Include(p => p.User)
            .SingleOrDefaultAsync(p => p.Id == id);

        model.Status = Domain.OrderStatus.Delivered;
        dbContext.Update(model);
        await dbContext.SaveChangesAsync();
        var body = $@"<h4> Merhabalar Sn. {model.User!.givenName} </h4><p>Siparişiniz teslim edilmiştir.</p>";

        await emailService.SendAsync(
            model.User.Email,
            "Siparişiniz Hakkında",
            body,
            true
            );
        return RedirectToAction(nameof(Index));

    }
    public async Task<IActionResult> ToCancalled(Guid id)
    {
        var model = await dbContext.shoppedOrders
            .Include(p => p.User)
            .SingleOrDefaultAsync(p => p.Id == id);

        model.Status = Domain.OrderStatus.Cancelled;
        dbContext.Update(model);
        await dbContext.SaveChangesAsync();
        var body = $@"<h4> Merhabalar Sn. {model.User!.givenName} </h4><p>Siparişinizin iptali işleme alınmıştır.</p>";

        await emailService.SendAsync(
            model.User.Email,
            "Siparişiniz Hakkında",
            body,
            true
            );
        return RedirectToAction(nameof(Index));

    }
    public async Task<IActionResult> PastAllOrders()
    {
        var item = await dbContext.shoppedOrders
            .Include(p => p.User)
            .Include(p => p.Order_Items)
            .ThenInclude(p => p.Product)
            .OrderByDescending(p => p.Date)
            .Where(p => p.Status == Domain.OrderStatus.Delivered && p.Status == Domain.OrderStatus.Cancelled)
            .ToListAsync();

        return View(item);
    }
    public async Task<IActionResult> Shipping(Guid id)
    {
        ViewData["Title"] = "Gönderilen Siparişler";

        var model = await dbContext
           .shoppedOrders
           .Include(p => p.User)
           .Include(p => p.Order_Items)
           .ThenInclude(p => p.Product)
           .Where(p => p.Status == OrderStatus.Shipped)
           .OrderByDescending(p => p.Date)
           .ToListAsync();

        return View("Index", model);
    }
    [HttpPost]
    public IActionResult Shipping(Guid id, string trackingNumber)
    {
        var order = dbContext.shoppedOrders.FirstOrDefault(p => p.Id == id);

        if (order == null) return NotFound();

        order.TrackingNumber = trackingNumber;
        order.Status = OrderStatus.Shipped; 
        order.Date = DateTime.Now;

        dbContext.SaveChanges();

        TempData["success"] = "Kargo takip numarası kaydedildi.";
        return RedirectToAction("Index");
    }

    [HttpPost]
    public async Task<IActionResult> UpdateTracking(Guid id, string trackingNumber)
    {
        if (string.IsNullOrWhiteSpace(trackingNumber))
        {
            TempData["error"] = "Kargo takip numarası boş olamaz.";
            return RedirectToAction("InProgess");
        }

        var order = await dbContext.shoppedOrders
            .Include(p => p.User)   
            .FirstOrDefaultAsync(p => p.Id == id);

        if (order == null)
            return NotFound();

        if (order.User == null)
            return BadRequest("Siparişin bir kullanıcısı yok! (User NULL)");

        order.TrackingNumber = trackingNumber;
        order.Status = OrderStatus.Shipped;
        order.Date = DateTime.Now;

        await dbContext.SaveChangesAsync();

        var body = $@"
        <h4>Merhabalar Sn. {order.User!.givenName}</h4>
        <p>Siparişiniz kargoya verilmiştir.</p>
        <p><b>Kargo Takip Numarası:</b> {trackingNumber}</p>
    ";

        await emailService.SendAsync(
            order.User.Email!,
            "Siparişiniz Kargoya Verildi",
            body,
            true
        );

        TempData["success"] = "Kargo takip numarası kaydedildi ve e-posta gönderildi.";

        return RedirectToAction("Shipped");
    }
    public IActionResult ApproveReturn(Guid id)
    {
        var order = dbContext.shoppedOrders.FirstOrDefault(p => p.Id == id);
        if (order == null) return NotFound();

        order.IsReturnApproved = true;
        dbContext.SaveChanges();

        return RedirectToAction("ReturnRequests");
    }
    public IActionResult RejectReturn(Guid id)
    {
        var order = dbContext.shoppedOrders.FirstOrDefault(p => p.Id == id);
        if (order == null) return NotFound();

        order.IsReturnApproved = false;
        order.IsReturnRequested = false;

        dbContext.SaveChanges();

        return RedirectToAction("ReturnRequests");
    }

    public IActionResult SetReturnTracking(Guid id)
    {
        var order = dbContext.shoppedOrders.FirstOrDefault(p => p.Id == id);
        if (order == null) return NotFound();

        return View(order);
    }

    [HttpPost]
    public IActionResult SetReturnTracking(Guid id, string trackingNumber)
    {
        var order = dbContext.shoppedOrders.FirstOrDefault(p => p.Id == id);
        if (order == null) return NotFound();

        order.ReturnTrackingNumber = trackingNumber;
        order.IsReturnApproved = true;

        dbContext.SaveChanges();

        TempData["success"] = "İade Kargo Kodu Kaydedildi.";
        return RedirectToAction("ReturnRequests");
    }

    public async Task<IActionResult> ReturnRequests()
    {
        var model = await dbContext.shoppedOrders
            .Include(p => p.User)
            .Include(p => p.Order_Items).ThenInclude(p => p.Product)
            .Where(p => p.IsReturnRequested == true)
            .OrderByDescending(p => p.Date)
            .ToListAsync();

        ViewData["Title"] = "İade Talepleri";
        return View("Index", model);
    }
    [HttpPost]
    public IActionResult AddReturnTracking(Guid id, string returnTrackingNumber)
    {
        var order = dbContext.shoppedOrders.FirstOrDefault(p => p.Id == id);
        if (order == null) return NotFound();

        order.ReturnTrackingNumber = returnTrackingNumber;
        dbContext.SaveChanges();

        TempData["success"] = "İade kargo kodu başarıyla eklendi.";
        return RedirectToAction("ReturnRequests");
    }
    [HttpPost]
    public async Task<IActionResult> CompleteReturn(Guid id)
    {
        var order = await dbContext.shoppedOrders
            .Include(p => p.User)
            .FirstOrDefaultAsync(p => p.Id == id);

        if (order == null)
            return NotFound(); 

        if (order.User == null)
            return BadRequest("Siparişin kullanıcısı bulunamadı."); 

        order.FinalReturnApproved = true;
        order.ReturnCompletedDate = DateTime.Now;

        await dbContext.SaveChangesAsync();

        var body = $@"
        <h4>Merhaba Sn. {order.User!.givenName},</h4>
        <p>İade ettiğiniz ürün tarafımıza ulaşmıştır.</p>
        <p>İade süreciniz başarıyla tamamlanmış olup ücret iadeleri 
        ortalama <b>1–3 iş günü</b> içerisinde hesabınıza aktarılacaktır.</p>
        <br>
        <p>Saygılarımızla,</p>
        <p><b>Mabeya Destek Ekibi</b></p>
    ";

        await emailService.SendAsync(
            order.User.Email!,
            "İade Süreci Tamamlandı",
            body,
            true
        );

        TempData["success"] = "İade tamamlandı ve kullanıcı bilgilendirildi.";

        return RedirectToAction("ReturnRequests"); 
    }
}
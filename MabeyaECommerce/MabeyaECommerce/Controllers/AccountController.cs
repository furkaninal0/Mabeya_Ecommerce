using MabeyaECommerce.Domain;
using MabeyaECommerce.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Shared;
using NETCore.MailKit.Core;
using System.Data;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MabeyaECommerce.Controllers;

public class AccountController (
    UserManager<User> userManager,
    SignInManager<User> signInManager,
    IEmailService emailService,
    MabeyaDbContext dbContext
    ) : Controller
{
    public IActionResult Login(string? returnUrl = null)
    {
        ViewBag.ReturnUrl = returnUrl;
        return View(new LoginUserModel { IsPersistent = true, ReturnUrl = returnUrl });
    }
    [HttpPost]
    public async Task<IActionResult> Login(LoginUserModel model)
    {
        var result = await signInManager.PasswordSignInAsync(
        model.UserName!,
        model.Password!,
        isPersistent: model.IsPersistent,
        lockoutOnFailure: true);

        if (result.Succeeded)
        {
            var user = await userManager.FindByNameAsync(model.UserName!);
            if (!user.IsEnabled)
                await signInManager.SignOutAsync();
            else
                return RedirectToLocal (model.ReturnUrl);
        }
        ModelState.AddModelError("", "Geçersiz kullanıcı girişi");
        return View(model);

    }
    private IActionResult RedirectToLocal(string? returnUrl)
    {
        if (!string.IsNullOrEmpty(returnUrl) && Url.IsLocalUrl(returnUrl))
            return Redirect(returnUrl);
        else
            return RedirectToAction("Index", "Home");
    }
    public IActionResult Register()
    {
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> Register(RegisterViewModel model)
    {
        var user = new User()
        {

            UserName = model.UserName,
            Email = model.UserName,
            givenName = model.GivenName,
            Date = DateTime.Now,
        };
        var result = await userManager.CreateAsync(user, model.Password!);
       
        if (result.Succeeded)
        {
            await userManager.AddToRoleAsync(user, "Members");
            var token = await userManager.GenerateEmailConfirmationTokenAsync(user);
            var link = Url.Action("EmailConfirmation", "Account", new { id = user.Id, token }, Request.Scheme);
            var body = $@"<h3> Merhaba Sn {user.givenName} </h3>
                        <p> Hesabınızı aktifleştirmek için aşağıdaki linke tıklayınız.</p>
                        <a href=""{link}"">Hesabımı Aktifleştir</a>"; 
            await emailService  
                .SendAsync
                (user.Email,
                "Hesap Aktifleştirme",
                body, 
                true
                );

            return View("RegisterSucces");
        }
        foreach (var error in result.Errors)
        {
            ModelState.AddModelError("", error.Description);
        }
        return View(model);
    }
    public async Task<IActionResult> EmailConfirmation(Guid id, string token)
    {
        var user = await userManager.FindByIdAsync(id.ToString());
        if (user == null) return View("Error");
        
        var result = await userManager.ConfirmEmailAsync(user, token);
        if (result.Succeeded)
        {
            await signInManager.SignInAsync(user, isPersistent: false);
            return RedirectToAction("Index", "Home");
        }
        return View();

    }
    [Authorize]
    public async Task<IActionResult> Logout()
    {
        await signInManager.SignOutAsync();
        return RedirectToAction("Index", "Home");
    }
    public IActionResult AccessDenied()
    {
        return View();
    }
    public IActionResult ResetPassword()
    {
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> ResetPassword(ResetPasswordViewModel model)
    {
        var user = await userManager.FindByNameAsync(model.UserName);
        if (user == null)
        {
            ModelState.AddModelError("", "Kullanıcı bulunamadı");
            return View(model);
        }
        var token = await userManager.GeneratePasswordResetTokenAsync(user);
        var link = Url.Action("SetPassword", "Account", new { id = user.Id, token }, Request.Scheme);
        var body = $@"<h3> Merhaba Sn {user.givenName} </h3>
                        <p> Şifrenizi yenilemek için aşağıdaki linke tıklayınız.</p>
                        <a href=""{link}"">Şifremi Yenile</a>";

        await emailService.SendAsync
            (user.Email,
            "Şifre Yenileme",
            body,
            true
            );
        return View("ResetPasswordEmailSend");
    }
    public async Task<IActionResult> SetPassword(SetPassWordViewModel model)
    {
       var user = await userManager.FindByIdAsync(model.Id!.ToString());
        var result = await userManager.ResetPasswordAsync(user!, model.Token!, model.Password);
        return View("SetPasswordSucces");
    }
    [Authorize]
    public async Task<IActionResult> RemoveFromCart(Guid id)
    {
        var userId = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
        await dbContext.shoppingCartItems.Where(p => p.Id == id && p.UserId == userId!).ExecuteDeleteAsync();
        return RedirectToAction(nameof(Checkout));
    }
    [HttpPost]
    [Authorize]
    public async Task<IActionResult> AddToCart(Guid id)
    {
        var userId = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
        var product = await dbContext.Products.SingleOrDefaultAsync(p => p.Id == id);
        if (product == null)
        {
            TempData["error"] = "Product not found!";
            return RedirectToAction("Index", "Home");
        }
        var item = await dbContext.shoppingCartItems.SingleOrDefaultAsync(p => p.UserId == userId && p.ProductId == id);
        if (item == null)
        {
            item = new ShoppingCartItem
            {
                ProductId = id,
                UserId = userId,
                Quantity = 1,
            };
            dbContext.shoppingCartItems.Add(item);
        }
        else
        {
            item.Quantity++;
            dbContext.shoppingCartItems.Update(item);
        }
        TempData["success"] = "Ürün başarıyla sepete eklendi.";
        await dbContext.SaveChangesAsync();
        return Redirect(Request.Headers["Referer"].ToString());

    }
    [Authorize]
    public IActionResult Payment()
    {
        return View();
    }
    [Authorize]
    public IActionResult Checkout()
    {
        return View();
    }
    [Authorize]

    public async Task<IActionResult> SetQuantity(Guid id, int Quantity)
    {
        var item = await dbContext.shoppingCartItems.SingleOrDefaultAsync(p=>p.Id == id);
        item.Quantity = Quantity;
        dbContext.Update(item);
        await dbContext.SaveChangesAsync();
        return RedirectToAction(nameof(Checkout));
    }
    [Authorize]

    public async Task<IActionResult> IncreaseQuantity(Guid id)
    {
        var item = await dbContext.shoppingCartItems.SingleOrDefaultAsync(p => p.Id == id);
        item.Quantity++;
        dbContext.Update(item);
        await dbContext.SaveChangesAsync();
        return RedirectToAction(nameof(Checkout));
    }
    [Authorize]

    public async Task<IActionResult> DecreaseQuantity(Guid id)
    {
        var item = await dbContext.shoppingCartItems.SingleOrDefaultAsync(p => p.Id == id);
        if (item.Quantity > 1)
        item.Quantity--;
        dbContext.Update(item);
        await dbContext.SaveChangesAsync();
        return RedirectToAction(nameof(Checkout));
    }

    [Authorize]
    [HttpPost]
    public async Task<IActionResult> CreateAddress([FromBody]AddressViewModel model)
    {
        var userıd = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
        var address = new Address()
        {
            Name = model.Name,
            Number = model.Number,
            Text = model.Text,
            zipCode = model.zipCode,
            cityId = model.CityId,
            userId = userıd,
        };
        dbContext.Add(address);
        await dbContext.SaveChangesAsync();
        return Ok();
    }

    [Authorize]
    public async Task<IActionResult> UserAddress()
    {
        var userId = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
        var model = await dbContext.Addresses
            .Where(a => a.userId == userId)
            .Select(p => new { p.Id, p.Name, p.Number, p.Text })
            .ToListAsync();
        return Json(model);
    }
    [Authorize]
    [HttpPost]
    [Consumes("application/json")]

    public async Task<IActionResult> Pay ([FromBody]PaymentViewModel model)
    {
        if(model==null)
            return BadRequest("Model null geldi");

        var userIdString = User.FindFirstValue(ClaimTypes.NameIdentifier);
        if(string.IsNullOrEmpty(userIdString))
            return Unauthorized("Kullanıcı kimliği bulunamadı");
        var userId = Guid.Parse(userIdString);
#if DEBUG
        Thread.Sleep(5000);
#endif
        var order = new ShoppedOrder()
        {
            Date = DateTime.Now,
            addressId = model.ShippingAddressId,
            userId = userId,
            Order_Items = dbContext.
            shoppingCartItems
            .Include(p=>p.Product)
            .Where(p => p.UserId == userId)
            .Select(p=> new ShoppedOrder_Item
            {
                Price = p.Product!.Price,
                Quantity = p.Quantity,
                productId = p.ProductId,

            }).ToList()
        };
        dbContext.Add(order);
        await dbContext.SaveChangesAsync();
        await dbContext.shoppingCartItems.Where(p => p.UserId == userId)
            .ExecuteDeleteAsync();
        return Ok();
    }
   
}

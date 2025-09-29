using MabeyaECommerce.Domain;
using MabeyaECommerce.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace MabeyaECommerce.Controllers;

public class AccountController (
    UserManager<User> userManager
    ): Controller
{
    public IActionResult Index()
    {
        return View();
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
        return View();
        if (result.Succeeded)
        {
            await userManager.AddToRoleAsync(user, "Members");
            var token = await userManager.GenerateEmailConfirmationTokenAsync(user);
            return View();
        }        
    }
    public async Task<IActionResult> EmailConfirmation(Guid id, string token)
    {
        var user = await userManager.FindByIdAsync(id.ToString());
        var result = await userManager.ConfirmEmailAsync(user, token);
    }


}

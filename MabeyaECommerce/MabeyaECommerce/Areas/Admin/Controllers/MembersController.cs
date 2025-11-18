using MabeyaECommerce.Areas.Admin.Models;
using MabeyaECommerce.Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MabeyaECommerce.Areas.Admin.Controllers;

[Area("Admin")]
[Authorize(Roles = "Administrators")]
public class MembersController (UserManager<User> userManager , MabeyaDbContext dbContext) : Controller
{
    public async Task<IActionResult> Members()
    {
        var users = userManager.Users.ToList();
        var model = new List<UserWithRolesDto>();

        foreach (var user in users)
        {
            var roles = await userManager.GetRolesAsync(user);
            if (!roles.Contains("Administrators"))
            {
            model.Add(new UserWithRolesDto
            {
                User = user,
                Roles = roles.ToList(),
                IsEnabled = user.IsEnabled,
            });
            }
        }
        return View(model);

    }
    public async Task<IActionResult> BanUser(Guid id)
    {
        var user = await userManager.FindByIdAsync(id.ToString());
        user!.IsEnabled = false;
        await userManager.UpdateAsync(user);

        return RedirectToAction(nameof(Members));
    }
    public async Task<IActionResult> UnbanUser(Guid id)
    {
        var user = await userManager.FindByIdAsync(id.ToString());
        user!.IsEnabled = true;
        await userManager.UpdateAsync(user);

        return RedirectToAction(nameof(Members));
    }
    public async Task<IActionResult> SetRoles(Guid id)
    {
        var user = await userManager.FindByIdAsync(id.ToString());
        if (user == null)
            return NotFound();
        var roles = await userManager.GetRolesAsync(user);
        var model = new UserWithRolesDto
        {
            User = user,
            Roles = roles.ToList(),
            IsEnabled = user.IsEnabled
        };

        return View(model);
    }
    [HttpPost]
    public async Task<IActionResult> SetRoles(Guid id, List<string> roles)
    {
        var user = await userManager.FindByIdAsync(id.ToString());
        if (user == null)
            return NotFound();
        var currentRoles = await userManager.GetRolesAsync(user);
        if (roles == null || !roles.Any())
        {
            return RedirectToAction(nameof(Members));
        }
        var rolesToRemove = currentRoles.Except(roles).ToList();
        var rolesToAdd = roles.Except(currentRoles).ToList();
        if (rolesToRemove.Any())
            await userManager.RemoveFromRolesAsync(user, rolesToRemove);
        if (rolesToAdd.Any())
            await userManager.AddToRolesAsync(user, rolesToAdd);

        await userManager.UpdateAsync(user);


        return RedirectToAction(nameof(Members));

    }

    public async Task<IActionResult> Detail(Guid id)
    {
        var user = dbContext.Users
          .FirstOrDefault(p => p.Id == id);

        if (user == null)
            return NotFound();

        var allAddresses = dbContext.Addresses
            .Include(a => a.City).ThenInclude(c => c.Province)
            .Where(a => a.UserId == id)
            .ToList();

        var shippingAddresses = allAddresses.Where(a => a.IsShipping).ToList();
        var billingAddresses = allAddresses.Where(a => a.IsInvoice).ToList();
        var orders = dbContext.shoppedOrders
            .Include(o => o.Order_Items)
            .Where(o => o.UserId == id)
            .ToList();

        var vm = new UserDetailViewModel
        {
            User = user,
            ShippingAddresses = shippingAddresses,
            BillingAddresses = billingAddresses,
            Orders = orders
        };

        return View(vm);
    }
}

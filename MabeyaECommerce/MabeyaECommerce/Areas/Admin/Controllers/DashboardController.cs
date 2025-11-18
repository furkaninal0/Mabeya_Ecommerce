using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MabeyaECommerce.Areas.Admin.Controllers;

[Area("Admin")]
[Authorize(Roles = "Administrators")]
public class DashboardController (MabeyaDbContext dbContext): Controller
{
    public IActionResult Index()
    {

        return View();
    }
    public IActionResult Tables()
    {
        return View();
    }
    public IActionResult MarketingAnalyst()
    {
        return View();
    }
   
}

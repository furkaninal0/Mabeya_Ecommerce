using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MabeyaECommerce.Areas.Admin.Controllers;

[Area("Admin")]
[Authorize(Roles = "Administrators")]
public class DashboardController : Controller
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

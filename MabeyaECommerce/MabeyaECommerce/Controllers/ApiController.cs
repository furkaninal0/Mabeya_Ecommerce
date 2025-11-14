using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace MabeyaECommerce.Controllers;

public class ApiController (MabeyaDbContext dbContext): Controller
{
    public async Task<IActionResult> GetCities(int id)
    {
        var model = await dbContext.Cities
            .Where(p=>p.provinceId==id)
            .OrderBy(p=>p.Name)
            .Select(p=> new {p.Id, p.Name})
            .ToListAsync();
        return Json(model); 
    }
}

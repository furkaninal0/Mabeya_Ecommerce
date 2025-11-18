using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System;

namespace MabeyaECommerce.Controllers;

public class AnalyticsController(MabeyaDbContext dbContext) : Controller
{
    public IActionResult Index()
    {
        var allVisits = dbContext.VisitLogs.ToList();
        ViewData["TotalVisit"] = allVisits.Count;
        ViewData["MemberVisits"] = allVisits.Count(v => v.UserId != null);
        ViewData["GuestVisits"] = allVisits.Count(v => v.UserId == null);

        var completedVisits = allVisits.Where(v => v.DurationSec > 0);

        if (completedVisits.Any())
        {
            ViewData["AvgDuration"] = Convert.ToInt32(completedVisits.Average(v => v.DurationSec));
        }
        else
        {
            ViewData["AvgDuration"] = 0; 
        }

        var oneWeekAgo = DateTime.Now.Date.AddDays(-6); 

        var recentVisits = allVisits.Where(v => v.StartTime.Date >= oneWeekAgo).ToList();

        var dateList = Enumerable.Range(0, 7)
            .Select(i => DateTime.Now.Date.AddDays(-i))
            .Reverse()
            .ToList();

        var weeklyData = from day in dateList
                         join visit in recentVisits on day.Date equals visit.StartTime.Date into g
                         select new
                         {
                             Day = day,
                             Count = g.Count() 
                         };

        ViewBag.WeeklyLabels = weeklyData.Select(x => x.Day.ToString("dd MMM"));
        ViewBag.WeeklyCounts = weeklyData.Select(x => x.Count);

        return View();
    }
}
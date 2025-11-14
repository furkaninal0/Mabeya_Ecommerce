using MabeyaECommerce.Domain;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace MabeyaECommerce.Middlewares;

public class VisitTrackingMiddleware
{
    private readonly RequestDelegate _next;

    public VisitTrackingMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task Invoke(HttpContext context, IServiceProvider services)
    {
        var path = context.Request.Path;

        // --- STATIC FILES SKIP ---
        if (path.StartsWithSegments("/lib") ||
            path.StartsWithSegments("/css") ||
            path.StartsWithSegments("/js") ||
            path.StartsWithSegments("/images") ||
            path.StartsWithSegments("/favicon.ico"))
        {
            await _next(context);
            return;
        }

        // --- ADMIN SKIP ---
        if (path.StartsWithSegments("/admin"))
        {
            await _next(context);
            return;
        }

        // --- ONLY ALLOW CERTAIN PUBLIC PAGES ---
        var allowed =
            path == "/" ||
            path.StartsWithSegments("/product") ||
            path.StartsWithSegments("/category");

        if (!allowed)
        {
            await _next(context);
            return;
        }

        using var scope = services.CreateScope();
        var db = scope.ServiceProvider.GetRequiredService<MabeyaDbContext>();

        var sessionId = context.Session.Id;
        if (string.IsNullOrEmpty(sessionId))
        {
            await _next(context);
            return;
        }

        var visit = await db.VisitLogs.FirstOrDefaultAsync(v => v.SessionId == sessionId);

        var userId = context.User.Identity?.IsAuthenticated == true
            ? context.User.FindFirstValue(ClaimTypes.NameIdentifier)
            : null;

        if (visit == null)
        {
            visit = new VisitLog
            {
                Id = Guid.NewGuid(),
                UserId = userId,
                SessionId = sessionId,
                StartTime = DateTime.Now,
                EndTime = DateTime.Now,
                DurationSec = 0
            };

            db.VisitLogs.Add(visit);
        }
        else
        {
            visit.EndTime = DateTime.Now;

            if (visit.UserId == null && userId != null)
                visit.UserId = userId;

            var duration = visit.EndTime - visit.StartTime;
            visit.DurationSec = (int)(duration?.TotalSeconds ?? 0);

            db.VisitLogs.Update(visit);
        }

        await db.SaveChangesAsync();

        await _next(context);
    }
}

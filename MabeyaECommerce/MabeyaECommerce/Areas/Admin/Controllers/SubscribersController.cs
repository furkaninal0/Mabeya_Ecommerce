using MailKit;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
using NETCore.MailKit.Core;
using System.Threading.Tasks;
namespace MabeyaECommerce.Areas.Admin.Controllers;


[Area("Admin")]
[Authorize(Roles = "Administrators")]
public class SubscribersController (MabeyaDbContext dbContext , IEmailService emailService) : Controller
{
        [HttpGet]
        public IActionResult Index()
        {
            var list = dbContext.Subscribers
                .OrderByDescending(x => x.CreatedAt)
                .ToList();

            return View(list);
        }


      
        [HttpPost]
        public async Task<IActionResult> SendMail(
            string subject,
            string message,
            [FromServices] IEmailService emailService
        )
        {
            var subscribers = dbContext.Subscribers.ToList();

            if (!subscribers.Any())
            {
                TempData["error"] = "Hiç abone yok!";
                return RedirectToAction("Index");
            }

         
            var htmlTemplate = System.IO.File.ReadAllText("wwwroot/mail-templates/newsletter.html");

            string finalHtml = htmlTemplate.Replace("{{MESSAGE_CONTENT}}", message);

            foreach (var s in subscribers)
            {
                await emailService.SendAsync(
                    s.Email,
                    subject,
                    finalHtml,
                    true
                );
            }

            TempData["success"] = "Toplu mail başarıyla gönderildi.";
            return RedirectToAction("Index");
        }
}



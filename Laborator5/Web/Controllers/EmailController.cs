using Microsoft.AspNetCore.Mvc;
using Web.Models;
using Web.Services;

namespace Web.Controllers
{
    public class EmailController : Controller
    {
        private readonly IEmailService _emailService;

        public EmailController(IEmailService emailService)
        {
            _emailService = emailService;
        }

        [HttpGet]
        public async Task<IActionResult> InboxPop3()
        {
            var emails = await _emailService.GetEmailsViaPop3();
            return View("Inbox", emails);
        }

        
        [HttpGet]
        public async Task<IActionResult> Inbox()
        {
            var emails = await _emailService.GetEmailsViaImap();
            return View(emails);
        }

        [HttpGet]
        public async Task<IActionResult> Details(string id)
        {
            var email = await _emailService.GetEmailDetails(id);
            return View(email);
        }

        [HttpGet]
        public async Task<IActionResult> DownloadEmail(string id)
        {
            var result = await _emailService.DownloadEmailWithAttachments(id);
            return result ? RedirectToAction("Details", new { id }) : StatusCode(500, "Failed to download email");
        }

        [HttpGet]
        public IActionResult SendEmail()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SendEmail(EmailModel email)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            
            var success = await _emailService.SendEmailWithAttachments(email);
            return RedirectToAction("Index", "Home");
        }
    }
}
using AspNetCore.ReCaptcha;
using GymManager.Application.Common.Exceptions;
using GymManager.Application.Contacts.Commands.SendContactEmail;
using GymManager.Application.Tickets.Commands.AddTicket;
using GymManager.Application.Tickets.Queries.GetTicketById;
using GymManager.UI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GymManager.UI.Controllers
{
    public class HomeController : BaseController
    {
        private readonly ILogger<HomeController> _logger;
        //private readonly Mediator mediator;

        public HomeController(ILogger<HomeController> logger)//, Mediator mediator)
        {
            _logger = logger;
            //this.mediator = mediator;
        }

        public async Task<IActionResult> Index()
        {
            return View();
        }


        [HttpGet("[controller]/[action]/{test}")]
        public async Task<IActionResult> Index2(string test)
        {
            var datatest = test;
            _logger.LogInformation(" -------------       HomeControl INDEX-2       ---------------");
            return View(datatest);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View(new SendContactEmailCommand());
        }

        [ValidateReCaptcha]
        [ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<IActionResult> Contact(SendContactEmailCommand command)
        {
            var result = await MediatorSendValidate(command);
            if (!result.IsValid)
            {
                ModelState.AddModelError("AntySpamResult", "Wypełnij pole ReCaptcha (zabezpieczenie przed spamem)");

                return View(command);
            }

            TempData["Success"] = "Wiadomość została wysłana do administratora";

            return RedirectToAction("Contact");
        }
    }
}


//throw new Exception("Nieobsłużony błąd!!!");
//_logger.LogInformation("HomeControler Task Index");
//_logger.LogError(new Exception("HomeControler-Error"), null);
//var ticket = await Mediatr.Send(new GetTicketByIdQuery { Id = 1 });
//await Mediatr.Send(new AddTicketCommand { Name = "VipTicket" });
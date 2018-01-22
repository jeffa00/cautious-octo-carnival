using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CarManager.Models;
using CarManager.Services;
using CCA.CarLib;

namespace CarManager.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmailSender _emailSender;


        public HomeController(IEmailSender emailSender)
        {
            _emailSender = emailSender;
        }

        public IActionResult Index()
        {
            // NOTE: I put this in just to demonstrate the Interface and dependency injection
            //_emailSender.SendEmailAsync("jeffa@gmail.com", "Hi, Jeff", "How is it going, sir?");
            Car myCar = new Car
            {
                Id = 1,
                Year = 2017,
                Make = "<strong>Toyota</strong>",
                Model = "Camry",
                NumberOfDoors = 4
            };

            return View(myCar);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

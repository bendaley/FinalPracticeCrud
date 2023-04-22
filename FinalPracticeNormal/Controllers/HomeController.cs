using FinalPracticeNormal.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FinalPracticeNormal.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private BryceApplicationContext bryceContext { get; set; }

        public HomeController(ILogger<HomeController> logger, BryceApplicationContext HarperTime)
        {
            _logger = logger;
            bryceContext = HarperTime;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Testing()
        {
            return View();
        }

        public IActionResult Dating()
        {
            return View();
        }

        [HttpGet]
        public IActionResult YouKnowYouWantThis()
        {
            return View();
        }

        [HttpPost]
        public IActionResult YouKnowYouWantThis(GetBryce gb)
        {
            bryceContext.Add(gb);
            bryceContext.SaveChanges();

            return View("ConfirmationTime", gb);

            //return View(ConfirmationTime, gb);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

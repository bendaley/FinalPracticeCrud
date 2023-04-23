using FinalPracticeNormal.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        private BryceApplicationContext bryceContext { get; set; }

        public HomeController(BryceApplicationContext HarperTime)
        {
            bryceContext = HarperTime;
        }

        public IActionResult Index()
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
            ViewBag.Majors = bryceContext.Majors.ToList();

            return View();
        }

        [HttpPost]
        public IActionResult YouKnowYouWantThis(GetBryce gb)
        {
            if (ModelState.IsValid)
            {
                bryceContext.Add(gb);
                bryceContext.SaveChanges();

                return View("ConfirmationTime", gb);
            }
            else
            {
                ViewBag.Majors = bryceContext.Majors.ToList();
                return View(gb);
            }

            
        }              

        public IActionResult BrycesBunch()
        {
            var lovelyApplicants = bryceContext.HopefulResponses
                .Include(x => x.Major)
                //.Where(x => x.TommyJohn == true)
                .OrderBy(x => x.LastName)
                .ToList();

            return View(lovelyApplicants);
        }

        [HttpGet]
        public IActionResult Edit (int applicationid)
        {
            ViewBag.Majors = bryceContext.Majors.ToList();

            var application = bryceContext.HopefulResponses.Single(x => x.ApplicationId == applicationid);

            return View("YouKnowYouWantThis", application);
        }

        [HttpPost]
        public IActionResult Edit (GetBryce gb)
        {
            bryceContext.Update(gb);
            bryceContext.SaveChanges();

            return RedirectToAction("BrycesBunch");
        }

        [HttpGet]
        public IActionResult Delete(int applicationid)
        {
            var application = bryceContext.HopefulResponses.Single(x => x.ApplicationId == applicationid);

            return View(application);
        }

        [HttpPost]
        public IActionResult Delete(GetBryce gb)
        {
            bryceContext.HopefulResponses.Remove(gb);
            bryceContext.SaveChanges();

            return RedirectToAction("BrycesBunch");
        }
    }
}

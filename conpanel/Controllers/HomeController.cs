using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using conpanel.Models;

namespace conpanel.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public ActionResult Dashboard()
        {
            return View("Dashboard");

        }
        public ActionResult Mail()
        {
            return View("Mail");

        }
        public ActionResult Database()
        {
            return View("Database");

        }
        public ActionResult Statistic()
        {
            return View("Statistic");

        }
        public ActionResult Plugins()
        {
            return View("Plugins");

        }
        public ActionResult Themes()
        {
            return View("Themes");

        }
        public ActionResult Accounts()
        {
            return View("Account");

        }
        public ActionResult Useru()
        {
            return View("Useru");

        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

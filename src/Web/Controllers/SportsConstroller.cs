using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class SportsController : Controller
    {
        public IActionResult Cricket()
        {
            return Content("Cricket");
        }

        public IActionResult Hockey()
        {
            return Content("<html><body><h1>Hockey</h1></body></html>", "text/html");
        }

        public IActionResult Pubg()
        {
            return Json(new { name = "Electronic game", description = "Pubg" });
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

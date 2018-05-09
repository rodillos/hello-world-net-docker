using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tp_southworks.Models;

namespace Tp_southworks.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Tutorial()
        {
            ViewData["Title"] = "Tutorial";
            ViewData["Message"] = "ASP.net core + Docker ";

            return View();
        }

        public IActionResult Docker()
        {
            ViewData["Title"] = "What's Docker?";
            ViewData["Message"] = "This view contains basic info about Docker.";

            return View();
        }

        public IActionResult Avanzado()
        {
            ViewData["Title"] = "Advanced Tutorials";
            ViewData["Message"] = "This View cotains advanced info for ASP.net core with Docker";

            return View();
        }
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

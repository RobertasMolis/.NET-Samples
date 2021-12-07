using FirstMvcApplication.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FirstMvcApplication.Controllers
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

        public IActionResult AboutMe()
        {
            var personModel = new PersonModel()
            {
                Name = "R M"
            };

            return View(personModel);

        }

        // Display a page with the form
        public IActionResult DisplaySubmitData()
        {
            var emptyModel = new PersonModel();
            return View(emptyModel);
        }

        // will receive filled model and will save to file

        public IActionResult SubmitData(PersonModel model)
        {
            // System.IO.File.WriteAllLines("test.txt", model.Name);

            System.IO.File.WriteAllText("test.txt", model.Name);
            return View(new PersonModel());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

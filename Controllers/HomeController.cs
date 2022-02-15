using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DojoSurveyWithValidation.Models;

namespace DojoSurveyWithValidation.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet("")]
        public ViewResult Index()
        {
            return View("Index");
        }

        [HttpPost("/survey")]
        public IActionResult Form(Survey yourSurvey)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("Results", yourSurvey);
            }

            return View("Index");
        }


        [HttpGet("/results")]
        public ViewResult Results(Survey yourSurvey)
        {
            return View("Results", yourSurvey);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

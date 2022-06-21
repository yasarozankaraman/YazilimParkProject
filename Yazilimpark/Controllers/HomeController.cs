using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Yazilimpark.Models;
using Yazilimpark.Services;

namespace Yazilimpark.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProjectService _projectService;
        public HomeController(IProjectService projectService)
        {
            _projectService = projectService;
        }

        public IActionResult Index()
        {
            var data = _projectService.GetProjects();
            return View(data);
        }

        public IActionResult Bmi()
        {
            return View();
        }

        public IActionResult RandomQuote()
        {
            return View();
        }

        public IActionResult ToDoList()
        {
            return View();

        }

        public IActionResult Weather()
        {
            return View();
           /* var city = new City
            {
                Humidity = 0,
                Name = "asd",
                Temperature = 345,
                Weather = "asdasd"
            };
            //var centerCities = new List<City>();

            return View("~/Views/WeatherForecast/City.cshtml",city );*/

        }
    }
}
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
        [HttpGet]
        public IActionResult Weather()
        {
            var viewModel = new SearchByCity();
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
        public IActionResult Weather(SearchByCity model)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("City", "WeatherForecast", new {city=model.CityName});
            }
            return View(model);
        }
        public IActionResult City(string city)
        {
            City viewModel=new City();
            return View(viewModel); 
        }
    }
}
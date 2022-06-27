using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Yazilimpark.Models;
using Yazilimpark.Repositories;
using Yazilimpark.Services;

namespace Yazilimpark.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWForecastRepository _WForecastRepository;

        private readonly IProjectService _projectService;
        public HomeController(IProjectService projectService, IWForecastRepository WForecastRepository)
        {
            _projectService = projectService;
            _WForecastRepository = WForecastRepository;

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
        public IActionResult SearchByCity()
        {
            var viewModel = new SearchByCity();
            return View(viewModel);
        }
        [HttpPost]
        public IActionResult SearchByCity(SearchByCity model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("City", "WeatherForecast", new { city = model.CityName });
            }
            return View(model);
        }

        private readonly string[] CenterCities = new[]
        {
            "Istanbul", "Paris", "Berlin", "London"
        };

        [HttpPost]
        public async Task<IActionResult> City(SearchByCity city)
        {
            var weatherReponse = await _WForecastRepository.GetForecast(city.CityName);
            var list = new List<City>();

            foreach (var item in CenterCities)
            {
                var res = await _WForecastRepository.GetForecast(item);
                var cityModel = MapWeatherNodel(res);
                list.Add(cityModel);
            }
            City viewModel = new City();
            if (weatherReponse != null)
            {
                viewModel = MapWeatherNodel(weatherReponse);
            }

            var view = new WeatherViewModel
            {
                CenterCities = list,
                SearchCity = viewModel
            };

            return View(view);
        }
        public float Donusturucu(float Kelvin)
        {
            float Celcius = (float)Math.Round(Kelvin-273,2);
            return Celcius;
        }
        [NonAction]
        private City MapWeatherNodel(OpenMapWeatherResponseModel weatherReponse)
        {
            var viewModel = new City();

            viewModel.Name = weatherReponse.Name;
            viewModel.Temperature = Donusturucu((float)weatherReponse.Main.Temp);
            viewModel.Humidity = weatherReponse.Main.Humidity;
            viewModel.Pressure = weatherReponse.Main.Pressure;
            viewModel.Weather = weatherReponse.Weather[0].Main;
            viewModel.Wind = (int)weatherReponse.Wind.Speed;

            return viewModel;
        }
       
    }
}
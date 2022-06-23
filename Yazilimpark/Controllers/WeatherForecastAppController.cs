using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Yazilimpark.Models;
using Yazilimpark.Services;
using Yazilimpark.Repositories;
using Yazilimpark.OpenWeatherMap_Model;

namespace Yazilimpark.Controllers
{
    public class WeatherForecastAppController : Controller
    {
        private readonly IWForecastRepository _WForecastRepository;
        public WeatherForecastAppController(IWForecastRepository WForecastRepository)
        {
            _WForecastRepository = WForecastRepository; 
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
                return RedirectToAction("City","WeatherForecast",new {city=model.CityName});
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult City (string city)
        {
            WeatherResponse weatherReponse = _WForecastRepository.GetForecast(city);
            City viewModel=new City();  
            if(weatherReponse != null)
            {
                viewModel.Name = weatherReponse.Name;
                viewModel.Temperature = weatherReponse.Main.Temp;
                viewModel.Humidity = weatherReponse.Main.Humidity;
                viewModel.Pressure = weatherReponse.Main.Pressure;
                viewModel.Weather = weatherReponse.Weather[0].Main;
                viewModel.Wind = weatherReponse.Wind.Speed;

            }
            return View(viewModel);
        }
    }
}

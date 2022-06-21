using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Yazilimpark.Models;
using Yazilimpark.Services;
namespace Yazilimpark.Controllers
{
    public class WeatherForecastAppController : Controller
    {
        [HttpGet]
        public IActionResult SearchByCity()
        {
            var viewModel = new SearchByCity();
            return View(viewModel);
        }
        public IActionResult SearchByCity(SearchByCity model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("City","WeatherForecast",new {city=model.CityName});
            }
            return View(model);
        }
        public IActionResult City (string city)
        {
            City viewModel=new City();  
            return View(viewModel);
        }
    }
}

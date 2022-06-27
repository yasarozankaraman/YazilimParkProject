using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Yazilimpark.Models;
using Yazilimpark.Services;
using Yazilimpark.Repositories;
using Yazilimpark.OpenWeatherMap_Model;

namespace Yazilimpark.Controllers
{
    public class WeatherForecastController : Controller
    {
        //private readonly IWForecastRepository _WForecastRepository;
        //public WeatherForecastController(IWForecastRepository WForecastRepository)
        //{
        //    _WForecastRepository = WForecastRepository; 
        //}
        //[HttpGet]
        //public IActionResult SearchByCity()
        //{
        //    var viewModel = new SearchByCity();
        //    return View(viewModel);
        //}
        //[HttpPost]
        //public IActionResult SearchByCity(SearchByCity model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        return RedirectToAction("City","WeatherForecast",new {city=model.CityName});
        //    }
        //    return View(model);
        //}
        //[HttpGet]
        //public async Task<IActionResult> City (string city)
        //{

        //    var weatherReponse =await  _WForecastRepository.GetForecast(city);


        //    City viewModel=new City();  
        //    if(weatherReponse != null)
        //    {
        //        viewModel.Name = weatherReponse.Name;
        //        viewModel.Temperature = (float)weatherReponse.Main.Temp;
        //        viewModel.Humidity = weatherReponse.Main.Humidity;
        //        viewModel.Pressure = weatherReponse.Main.Pressure;
        //        viewModel.Weather = weatherReponse.Weather[0].Main;
        //        viewModel.Wind =(int)weatherReponse.Wind.Speed;

        //    }
        //    return View(viewModel);
        //}
    }
}

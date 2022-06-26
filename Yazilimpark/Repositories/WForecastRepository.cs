using System.Text.Json;
using Yazilimpark.Models;
using Yazilimpark.OpenWeatherMap_Model;

namespace Yazilimpark.Repositories
{
    public class WForecastRepository : IWForecastRepository
    {
      public async Task<OpenMapWeatherResponseModel> GetForecast(string city)
        {
            using var client = new HttpClient();

            var res = await client.GetAsync($"https://api.openweathermap.org/data/2.5/weather?q={city}&appid=4e370b87a3a0589717fb848fc2b7f46e");

            var json = await res.Content.ReadAsStringAsync();
            
            var model = JsonSerializer.Deserialize<OpenMapWeatherResponseModel>(json);
            return model;
        }
    }
}

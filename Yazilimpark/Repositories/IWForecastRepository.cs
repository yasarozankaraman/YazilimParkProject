using Yazilimpark.OpenWeatherMap_Model;

namespace Yazilimpark.Repositories
{
    public interface IWForecastRepository
    {
        WeatherResponse GetForecast(string city);

    }
}

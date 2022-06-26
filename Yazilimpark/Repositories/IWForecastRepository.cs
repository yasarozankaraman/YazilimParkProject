using Yazilimpark.Models;
using Yazilimpark.OpenWeatherMap_Model;

namespace Yazilimpark.Repositories
{
    public interface IWForecastRepository
    {
        Task<OpenMapWeatherResponseModel> GetForecast(string city);

    }
}

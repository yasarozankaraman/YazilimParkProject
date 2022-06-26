using System.Text.Json.Serialization;

namespace Yazilimpark.OpenWeatherMap_Model
{
    public class Coord
    {
        [JsonPropertyName("lat")]
        public float Lat { get; set; }

        [JsonPropertyName("lon")]
        public float Lon { get; set; }
    }
}

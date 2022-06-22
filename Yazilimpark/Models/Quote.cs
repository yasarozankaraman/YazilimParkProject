using System.Text.Json.Serialization;

namespace Yazilimpark.Models
{
    public class Quote
    {
        [JsonPropertyName("content")]
        public string Text { get; set; }
        [JsonPropertyName("author")]
        public string Author { get; set; }
    }
}

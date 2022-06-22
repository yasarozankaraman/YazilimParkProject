
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Yazilimpark.Models;

namespace Yazilimpark.Services
{
    public class QuoteService: IQuoteService
    {
        private readonly QuoteApiConfig _config;

        public QuoteService(IOptions<QuoteApiConfig> config)
        {
            _config = config.Value;
        }
        public async Task<Quote> GetRandomQuote()
        {
            using var client = new HttpClient();
            var res = await client.GetStringAsync(_config.Url);

            var model = JsonSerializer.Deserialize<Quote>(res);

            return model;
        }
    }

    public interface IQuoteService
    {
        Task<Quote> GetRandomQuote();
    }
}


using Microsoft.AspNetCore.Mvc;
using Yazilimpark.Services;

namespace Yazilimpark.Controllers
{
    [Route("api")]
    public class RestController : ControllerBase
    {
        private readonly IQuoteService _quoteService;
        public RestController(IQuoteService quoteService)
        {
            _quoteService = quoteService;   
        }
        [HttpGet("quote")]
        public async Task<IActionResult> GetRandomQuote()
        {
            var model = await _quoteService.GetRandomQuote();
            return Ok(model);
        }
    }
}

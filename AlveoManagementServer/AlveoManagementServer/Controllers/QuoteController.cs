using AlveoManagementServer.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AlveoManagementServer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QuoteController : ControllerBase
    {
        private readonly ILogger<QuoteController> logger;
        private readonly IQuoteService quoteService;

        public QuoteController(ILogger<QuoteController> logger, IQuoteService quoteService)
        {
            this.logger = logger;
            this.quoteService = quoteService;
        }

        [HttpGet("GetAllQuotes")]
        public ActionResult GetAllQuotes()
        {
            logger.LogInformation("Getting all Quotes");
            return new ObjectResult(quoteService.GetAllQuotes());
        }
    }
}

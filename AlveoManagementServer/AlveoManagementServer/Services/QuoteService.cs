using AlveoManagementCommon.Classes;
using AlveoManagementServer.Services.Interfaces;
using DBProviderBase.Interfaces;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Data.SQLite;

namespace AlveoManagementServer.Services {
    public class QuoteService : IQuoteService
    {
        private readonly ILogger<QuoteService> logger;
        private readonly IDataService dataService;

        public QuoteService(ILogger<QuoteService> logger, IDataService dataService)
        {
            this.logger = logger;
            this.dataService = dataService;
        }

        public List<Quote> GetAllQuotes()
        {
            logger.LogDebug("Getting all quotes");
            return dataService.GetObjectData<Quote>();
        }

    }
}

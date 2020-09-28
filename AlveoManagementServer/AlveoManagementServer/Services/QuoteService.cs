using AlveoManagementCommon.Classes;
using AlveoManagementServer.Services.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace AlveoManagementServer.Services
{
    public class QuoteService : IQuoteService
    {
        private readonly ILogger<QuoteService> logger;

        public QuoteService(ILogger<QuoteService> logger)
        {
            this.logger = logger;
        }


        public List<Quote> GetAllQuotes()
        {
            logger.LogDebug("Getting all quotes");
            List<Quote> quote = new List<Quote>();
            quote.Add(new Quote()
            {
                orderNr = "ord523",
                projectName = "test project",
                forAttention = "test attention 1",
                date = DateTime.Today.ToString("dd/MM/yyyy"),
                quoteNumber = "EQ20-035",
                validUntil = DateTime.Today.AddDays(30).ToString("dd/MM/yyyy"),
                subTotal = 10000,
                taxRate = 15,
                taxDue = 1500,
                otherCosts = 0,
                quoteTotal = 11500,
                status = "Quoted"
            }
                  );
            quote.Add(new Quote()
            {
                orderNr = "ord524",
                projectName = "test project",
                forAttention = "test attention 2",
                date = DateTime.Today.ToString("dd/MM/yyyy"),
                quoteNumber = "EQ20-036",
                validUntil = DateTime.Today.AddDays(30).ToString("dd/MM/yyyy"),
                subTotal = 20000,
                taxRate = 15,
                taxDue = 3000,
                otherCosts = 0,
                quoteTotal = 23000,
                status = "invoiced"
            }
                );
            return quote;
        }

    }
}

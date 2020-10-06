using AlveoManagementCommon.Classes;
using AlveoManagementServer.Services.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using AlveoManagementServer.SQLite;

namespace AlveoManagementServer.Services
{
    public class QuoteService : IQuoteService
    {
        private readonly ILogger<QuoteService> logger;

        public QuoteService(ILogger<QuoteService> logger)
        {
            this.logger = logger;
        }

        Database databaseObject = new Database();

        public List<Quote> GetAllQuotes()
        {
            logger.LogDebug("Getting all quotes");
            List<Quote> quote = new List<Quote>();
            string selectQuotes = "SELECT * FROM Quotes";
            SQLiteCommand selectCommand = new SQLiteCommand(selectQuotes, databaseObject.dataConnection);
            databaseObject.OpenConnection();
            SQLiteDataReader selectResult = selectCommand.ExecuteReader();
            if (selectResult.HasRows)
            {
                while (selectResult.Read())
                {
                    quote.Add(new Quote()
                    {
                        orderNr = (string)selectResult["orderNr"],
                        projectName = (string)selectResult["projName"],
                        forAttention = (string)selectResult["forAtt"],
                        date = (string)selectResult["date"],
                        quoteNumber = (string)selectResult["quoteNr"],
                        validUntil = (string)selectResult["validUntil"],
                        subTotal = (double)selectResult["subTotal"],
                        taxRate = (double)selectResult["taxRate"],
                        taxDue = (double)selectResult["taxDue"],
                        otherCosts = (double)selectResult["otherCosts"],
                        quoteTotal = (double)selectResult["quoteTotal"],
                        status = (string)selectResult["status"]
                    }
                    );
                }
            }
            databaseObject.CloseConnection();
            return quote;
        }

    }
}

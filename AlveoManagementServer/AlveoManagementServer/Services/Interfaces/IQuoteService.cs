using AlveoManagementCommon.Classes;
using System.Collections.Generic;

namespace AlveoManagementServer.Services.Interfaces
{
    public interface IQuoteService
    {
        List<Quote> GetAllQuotes();
    }
}

using AlveoManagementCommon.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlveoManagementServer.Services.Interfaces
{
    public interface IQuoteService
    {
        List<Quote> GetAllQuotes();
    }
}

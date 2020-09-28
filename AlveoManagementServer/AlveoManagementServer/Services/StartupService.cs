using AlveoManagementServer.Services.Interfaces;
//using GoogleSheets;
using Microsoft.Extensions.Logging;

namespace AlveoManagementServer.Services
{
    public class StartupService : IStartupService
    {
        private readonly ILogger<StartupService> logger;
        // private readonly IGoogleSheetsService googleSheetsService;

        public StartupService(ILogger<StartupService> logger/*, IGoogleSheetsService googleSheetsService*/)
        {
            this.logger = logger;
            //this.googleSheetsService = googleSheetsService;
            logger.LogInformation("Startup Service Started");

            //ValueRange res = googleSheetsService.ReadSheet();

            //googleSheetsService.WriteToSheet();
            logger.LogInformation("Startup Service Completed");
        }
    }
}

using AlveoManagementCommon.Classes;
using AlveoManagementServer.Services.Interfaces;
using DBProviderBase.Interfaces;
//using GoogleSheets;
using Microsoft.Extensions.Logging;

namespace AlveoManagementServer.Services
{
    public class StartupService : IStartupService
    {
        private readonly ILogger<StartupService> logger;
        private readonly IDataService dataService;

        // private readonly IGoogleSheetsService googleSheetsService;

        public StartupService(ILogger<StartupService> logger, IDataService dataService/*, IGoogleSheetsService googleSheetsService*/)
        {
            this.logger = logger;
            this.dataService = dataService;
            //this.googleSheetsService = googleSheetsService;
            logger.LogInformation("Startup Service Started");

            dataService.TestConnection();
            //Test DB connection
            //Run DB maintenance
            DBTableMaintenace();

            //ValueRange res = googleSheetsService.ReadSheet();

            //googleSheetsService.WriteToSheet();
            logger.LogInformation("Startup Service Completed");
        }

        private void DBTableMaintenace()
        {
            logger.LogDebug("Running table maintenance.");
            dataService.CreatOrAlterObjectTable<Customer>();
            dataService.CreatOrAlterObjectTable<GanttData>();
            dataService.CreatOrAlterObjectTable<GanttLink>();
            dataService.CreatOrAlterObjectTable<Item>();
            dataService.CreatOrAlterObjectTable<User>();
            dataService.CreatOrAlterObjectTable<Personnel>();
            dataService.CreatOrAlterObjectTable<Warning>();
            dataService.CreatOrAlterObjectTable<Project>();
            dataService.CreatOrAlterObjectTable<Quote>();
            logger.LogDebug("Completed table maintenance.");
        }
    }
}

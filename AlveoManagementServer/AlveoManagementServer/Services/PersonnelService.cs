using AlveoManagementCommon.Classes;
using AlveoManagementServer.Services.Interfaces;
using DBProviderBase.Interfaces;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace AlveoManagementServer.Services {
    public class PersonnelService : IPersonnelService
    {
        private readonly ILogger<PersonnelService> logger;
        private readonly IDataService dataService;

        public PersonnelService(ILogger<PersonnelService> logger, IDataService dataService)
        {
            this.logger = logger;
            this.dataService = dataService;
        }

        public List<Personnel> GetAllPersonnelDetails()
        {
            logger.LogDebug("Getting all Personnel Details");
            return dataService.GetObjectData<Personnel>();
        }

        public void SavePersonnel(Personnel personnel)
        {
            dataService.InsertObjectData(personnel);
        }
    }
}

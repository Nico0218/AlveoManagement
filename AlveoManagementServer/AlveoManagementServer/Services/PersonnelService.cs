using AlveoManagementCommon.Classes;
using AlveoManagementServer.Services.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace AlveoManagementServer.Services
{
    public class PersonnelService : IPersonnelService
    {
        private readonly ILogger<PersonnelService> logger;

        public PersonnelService(ILogger<PersonnelService> logger)
        {
            this.logger = logger;
        }


        public List<Personnel> GetAllPersonnelDetails()
        {
            logger.LogDebug("Getting all Personnel Details");
            List<Personnel> personnel = new List<Personnel>();
            personnel.Add(new Personnel()
            {
                ID = Guid.NewGuid().ToString(),
                Name = "Tinus",
                Surname = "Spangenberg",
                StartDate = "01/10/19",
                ContactNumber = "0828987503"
            }
                  );
            personnel.Add(new Personnel()
            {
                ID = Guid.NewGuid().ToString(),
                Name = "Kobus",
                Surname = "Burger",
                StartDate = "01/01/18",
                ContactNumber = "0624589536"
            }
                  );
            personnel.Add(new Personnel()
            {
                ID = Guid.NewGuid().ToString(),
                Name = "Gerhardt",
                Surname = "Kieser",
                StartDate = "01/05/12",
                ContactNumber = "0848562548"
            }
                  );
            return personnel;
        }
    }
}

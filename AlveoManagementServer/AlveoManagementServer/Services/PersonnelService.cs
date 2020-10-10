using AlveoManagementCommon.Classes;
using AlveoManagementServer.Services.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using AlveoManagementServer.SQLite;

namespace AlveoManagementServer.Services
{
    public class PersonnelService : IPersonnelService
    {
        private readonly ILogger<PersonnelService> logger;

        public PersonnelService(ILogger<PersonnelService> logger)
        {
            this.logger = logger;
        }


        Database databaseObject = new Database();

        public List<Personnel> GetAllPersonnelDetails()
        {
            logger.LogDebug("Getting all Personnel Details");
            List<Personnel> personnel = new List<Personnel>();
            string selectPersonnel = "SELECT * FROM Personnel";
            SQLiteCommand selectCommand = new SQLiteCommand(selectPersonnel, databaseObject.dataConnection);
            databaseObject.OpenConnection();
            SQLiteDataReader selectResult = selectCommand.ExecuteReader();
            if (selectResult.HasRows)
            {
                while (selectResult.Read())
                {
                    personnel.Add(new Personnel()
                    {
                        ID = (string)selectResult["id"],
                        Name = (string)selectResult["name"],
                        Surname = (string)selectResult["surname"],
                        StartDate = (string)selectResult["startDate"],
                        ContactNumber = (string)selectResult["contactNumber"]
                    }
                    );
                }
            }
            databaseObject.CloseConnection();
            return personnel;
        }
    }
}

using AlveoManagementCommon.Classes;
using AlveoManagementServer.Services.Interfaces;
using DBProviderBase.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace AlveoManagementServer.Services
{
    public class LoginService : ILoginService
    {
        private readonly ILogger<LoginService> logger;
        private readonly IDataService dataService;

        public LoginService(ILogger<LoginService> logger, IDataService dataService)
        {
            this.logger = logger;
            this.dataService = dataService;
        }


        public List<User> GetAuthorisation()
        {
            logger.LogDebug("Getting login authentication");
            dataService.GetObjectData<User>();
            List<User> users = new List<User>();
            users.Add(
                new User()
                {
                    ID = Guid.NewGuid().ToString(),
                    Username = "Tinus",
                    Password = "password1234",
                    Name = "Tinus",
                    LastName = "Spangenberg"
                }
            );

            return users;
        }
    }
}

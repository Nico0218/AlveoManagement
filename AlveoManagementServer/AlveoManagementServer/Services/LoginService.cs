using AlveoManagementCommon.Classes;
using AlveoManagementServer.Services.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace AlveoManagementServer.Services
{
    public class LoginService : ILoginService
    {
        private readonly ILogger<LoginService> logger;

        public LoginService(ILogger<LoginService> logger)
        {
            this.logger = logger;
        }


        public List<User> GetAuthorisation()
        {
            logger.LogDebug("Getting login authentication");
            List<User> users = new List<User>();
            users.Add(new User()
            {
                id = Guid.NewGuid().ToString(),
                username = "Tinus",
                password = "password1234",
                firstName = "Tinus",
                lastName = "Spangenberg"
            }
                  );

            return users;
        }
    }
}

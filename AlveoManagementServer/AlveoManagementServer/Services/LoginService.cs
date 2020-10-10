using AlveoManagementCommon.Classes;
using AlveoManagementCommon.Classes.Login_Classes;
using AlveoManagementServer.Services.Interfaces;
using DBProviderBase.Classes;
using DBProviderBase.Interfaces;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;

namespace AlveoManagementServer.Services {
    public class LoginService : ILoginService {
        private readonly ILogger<LoginService> logger;
        private readonly IDataService dataService;

        public LoginService(ILogger<LoginService> logger, IDataService dataService) {
            this.logger = logger;
            this.dataService = dataService;

            EnsureTestData();
        }

        private void EnsureTestData() {
            if (dataService.GetObjectData<User>().Count == 0) {
                User user = new User() {
                    ID = "E0BC3703 - FA54 - 4B5C - B1D7 - 031529D3E740",
                    Name = "Tinus",
                    UserName = "admin",
                    Password = "admin",
                    LastName = "Spangenberg",
                    Email = "tinus@alveowater.co.za",
                    AuthData = ""
                };
                dataService.InsertObjectData(user);

                user = new User() {
                    ID = "C9319197-853E-4CD1-9A5C-8E1280764AD2",
                    UserName = "Morne",
                    Password = "MV@Manage258",
                    Name = "Morne",
                    LastName = "Viljoen",
                    Email = "Morne.viljoen@alveoenergy.co.za",
                    AuthData = ""
                };
                dataService.InsertObjectData(user);

                user = new User() {
                    ID = "F631EB76-EB4B-488B-A559-4D89C6266C52",
                    UserName = "Kobus",
                    Password = "KB@Manage456",
                    Name = "Kobus",
                    LastName = "Burger",
                    Email = "kobus.burger@alveoenergy.co.za",
                    AuthData = ""
                };
                dataService.InsertObjectData(user);

                user = new User() {
                    ID = "D4E72B01-344C-4983-8528-78F499DDC2EA",
                    UserName = "D andre",
                    Password = "DV@Manage159",
                    Name = "D andre",
                    LastName = "vosloo",
                    Email = "dandre.vosloo@alveoenergy.co.za",
                    AuthData = ""
                };
                dataService.InsertObjectData(user);

                user = new User() {
                    ID = "C0822FD8-47E5-4818-9CE9-C8755C2A0F46",
                    UserName = "Gerhard",
                    Password = "GK@Manage357",
                    Name = "Gerhard",
                    LastName = "Kieser",
                    Email = "gerhard.kieser@alveoenergy.co.za",
                    AuthData = ""
                };
                dataService.InsertObjectData(user);
            }
        }

        public User Login(LoginRequest loginRequest) {
            List<IParameter> parameters = new List<IParameter>();
            parameters.Add(new Parameter() { ColumnName = "UserName", DataType = "System.String", Operator = DBProviderBase.Enums.ParamOperator.Equals, Value = loginRequest.UserName });
            parameters.Add(new Parameter() { ColumnName = "Password", DataType = "System.String", Operator = DBProviderBase.Enums.ParamOperator.Equals, Value = loginRequest.UserName });
            if (dataService.GetObjectData<User>().FirstOrDefault() != null) {
                User user = dataService.GetObjectData<User>().FirstOrDefault();
                logger.LogInformation($"User {user.UserName} has logged in.");
                return user;
            }
            return null;
        }
    }
}

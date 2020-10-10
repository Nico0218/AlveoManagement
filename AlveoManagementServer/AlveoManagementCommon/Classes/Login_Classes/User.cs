using AlveoManagementCommon.Interfaces.Login_Interfaces;

namespace AlveoManagementCommon.Classes
{
    public class User : IUser
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }        
        public string AuthData { get; set; }        
    }
}

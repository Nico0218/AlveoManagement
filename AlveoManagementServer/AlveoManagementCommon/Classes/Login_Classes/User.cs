using AlveoManagementCommon.Interfaces.Login_Interfaces;

namespace AlveoManagementCommon.Classes
{
    public class User : IUser
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string AuthData { get; set; }        
    }
}

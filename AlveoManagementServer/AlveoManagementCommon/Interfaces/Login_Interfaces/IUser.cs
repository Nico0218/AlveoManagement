

namespace AlveoManagementCommon.Interfaces.Login_Interfaces
{
    public interface IUser
    {
        public string id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string authdata { get; set; }
    }
}

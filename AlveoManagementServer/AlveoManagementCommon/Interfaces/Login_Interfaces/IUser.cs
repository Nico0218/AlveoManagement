

namespace AlveoManagementCommon.Interfaces.Login_Interfaces
{
    public interface IUser : IDataModelBase
    {
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string AuthData { get; set; }
    }
}

using AlveoManagementCommon.Classes;
using AlveoManagementCommon.Classes.Login_Classes;

namespace AlveoManagementServer.Services.Interfaces {
    public interface ILoginService
    {
        User Login(LoginRequest loginRequest);
    }
}

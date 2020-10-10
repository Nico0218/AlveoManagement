using AlveoManagementCommon.Classes;
using AlveoManagementCommon.Classes.Login_Classes;
using AlveoManagementServer.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AlveoManagementServer.Controllers {
    [ApiController]
    [Route("[controller]")]
    public class LoginController : ControllerBase {
        private readonly ILogger<LoginController> logger;
        private readonly ILoginService loginService;

        public LoginController(ILogger<LoginController> logger, ILoginService loginService) {
            this.logger = logger;
            this.loginService = loginService;
        }

        [HttpPost("Login")]
        public ActionResult Login(LoginRequest loginRequest) {
            logger.LogInformation("Attempting login");
            User user = loginService.Login(loginRequest);
            if (user != null)
                return new ObjectResult(user);
            else
                return new UnauthorizedObjectResult("Invalid user name or password.");
        }
    }
}
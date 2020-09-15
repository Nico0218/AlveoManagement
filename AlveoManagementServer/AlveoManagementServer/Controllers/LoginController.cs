using AlveoManagementServer.Services;
using AlveoManagementServer.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AlveoManagementServer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController : ControllerBase
    {
        private readonly ILogger<LoginController> logger;
        private readonly ILoginService loginService;

        public LoginController(ILogger<LoginController> logger, ILoginService loginService)
        {
            this.logger = logger;
            this.loginService = loginService;
        }

        [HttpGet("GetAuthorisation")]
        public ActionResult GetAuthorisation()
        {
            logger.LogInformation("Getting all personnel Details");
            return new ObjectResult(loginService.GetAuthorisation());
        }
    }
}
using AlveoManagementServer.Services;
using AlveoManagementServer.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AlveoManagementServer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MailController : ControllerBase
    {
        private readonly ILogger<MailController> logger;
        private readonly IMailService mailService;

        public MailController(ILogger<MailController> logger, IMailService personnelService)
        {
            this.logger = logger;
            this.mailService = mailService;
        }

        [HttpGet("SendMail")]
        public ActionResult SendMail()
        {
            logger.LogInformation("Getting all personnel Details");
            return new ObjectResult(mailService.SendMail());
        }
    }
}
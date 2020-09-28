using AlveoManagementServer.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AlveoManagementServer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonnelController : ControllerBase
    {
        private readonly ILogger<PersonnelController> logger;
        private readonly IPersonnelService personnelService;

        public PersonnelController(ILogger<PersonnelController> logger, IPersonnelService personnelService)
        {
            this.logger = logger;
            this.personnelService = personnelService;
        }

        [HttpGet("GetAllPersonnelDetails")]
        public ActionResult GetAllPersonnelDetails()
        {
            logger.LogInformation("Getting all personnel Details");
            return new ObjectResult(personnelService.GetAllPersonnelDetails());
        }
    }
}
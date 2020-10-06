using AlveoManagementServer.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AlveoManagementServer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProjectController : ControllerBase
    {
        private readonly ILogger<ProjectController> logger;
        private readonly IProjectService projectService;

        public ProjectController(ILogger<ProjectController> logger, IProjectService projectService)
        {
            this.logger = logger;
            this.projectService = projectService;
        }

        [HttpGet("GetAllProjects")]
        public ActionResult GetAllProjects()
        {
            logger.LogInformation("Getting all Projects");
            return new ObjectResult(projectService.GetAllProjects());
        }
    }
}

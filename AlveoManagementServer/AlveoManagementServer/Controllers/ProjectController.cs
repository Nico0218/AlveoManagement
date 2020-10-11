using AlveoManagementServer.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AlveoManagementCommon.Classes;

namespace AlveoManagementServer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProjectController : ControllerBase
    {
        private readonly ILogger<ProjectController> logger;
        private readonly IProjectService projectService;
        private readonly IGanttDataService ganttDataService;

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

        [HttpPost("WriteProjectToDB")]
        public ActionResult WriteProjectToDb(newProject project)
        {
            logger.LogInformation("adding new project to DB");
        }

    }
}

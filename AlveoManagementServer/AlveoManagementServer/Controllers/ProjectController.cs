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

        public ProjectController(ILogger<ProjectController> logger, IProjectService projectService, IGanttDataService ganttDataService)
        {
            this.logger = logger;
            this.projectService = projectService;
            this.ganttDataService = ganttDataService;
        }

        [HttpGet("GetAllProjects")]
        public ActionResult GetAllProjects()
        {
            logger.LogInformation("Getting all Projects");
            return new ObjectResult(projectService.GetAllProjects());
        }

        [HttpPost("SaveProject")]
        public ActionResult SaveProject(Project project)
        {
            logger.LogInformation("adding new project to DB");
            ganttDataService.SaveProject(project);
            return new ObjectResult("true");
        }

        [HttpPost("DeleteProject")]
        public ActionResult DeleteProject(Project project) {
            logger.LogInformation("Updating project");
            ganttDataService.DeleteProject(project);
            return new ObjectResult("true");
        }

        [HttpPost("UpdateProject")]
        public ActionResult UpdateProject(Project project)
        {
            logger.LogInformation("Updating project");
            ganttDataService.UpdateProject(project);
            return new ObjectResult("true");
        }

        [HttpPost("SaveTask")]
        public ActionResult SaveTask(Task task)
        {
            logger.LogInformation("adding new project to DB");
            ganttDataService.SaveTask(task);
            return new ObjectResult("true");
        }

    }
}

using AlveoManagementServer.Services;
using AlveoManagementServer.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AlveoManagementServer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GanttDataController : ControllerBase
    {
        private readonly ILogger<GanttDataController> logger;
        private readonly IGanttDataService ganttDataService;

        public GanttDataController(ILogger<GanttDataController> logger, IGanttDataService ganttDataService)
        {
            this.logger = logger;
            this.ganttDataService = ganttDataService;
        }

        [HttpGet("GetAllGanttData")]
        public ActionResult GetAllGanttData()
        {
            logger.LogInformation("Getting all gantt data");
            return new ObjectResult(ganttDataService.GetAllGanttData());
        }

        [HttpGet("GetAllGanttLinks")]
        public ActionResult GetAllGanttLinks()
        {
            logger.LogInformation("Getting all gantt links");
            return new ObjectResult(ganttDataService.GetAllGanttLinks());
        }

    }
}
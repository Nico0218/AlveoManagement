using AlveoManagementServer.Services;
using AlveoManagementServer.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AlveoManagementServer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GanttController : ControllerBase
    {
        private readonly ILogger<GanttController> logger;
        private readonly IGanttService ganttService;

        public GanttController(ILogger<GanttController> logger, IGanttService ganttService)
        {
            this.logger = logger;
            this.ganttService = ganttService;
        }

        [HttpGet("GetAllGanttData")]
        public ActionResult GetAllGanttData()
        {
            logger.LogInformation("Getting all gantt data");
            return new ObjectResult(ganttService.GetAllGanttData());
        }
    }
}
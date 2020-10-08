using AlveoManagementServer.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AlveoManagementServer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InventoryController : ControllerBase
    {
        private readonly ILogger<InventoryController> logger;
        private readonly IInventoryService inventoryService;

        public InventoryController(ILogger<InventoryController> logger, IInventoryService inventoryService)
        {
            this.logger = logger;
            this.inventoryService = inventoryService;
        }

        [HttpGet("GetAllAutomation")]
        public ActionResult GetAllAutomation()
        {
            logger.LogInformation("Getting all Automation");
            return new ObjectResult(inventoryService.GetAllAutomation());
        }

        [HttpGet("GetAllCabletrays")]
        public ActionResult GetAllCabletrays()
        {
            logger.LogInformation("Getting all Cabletrays");
            return new ObjectResult(inventoryService.GetAllCabletrays());
        }

        [HttpGet("GetAllExtras")]
        public ActionResult GetAllExtras()
        {
            logger.LogInformation("Getting all Extras");
            return new ObjectResult(inventoryService.GetAllExtras());
        }

        [HttpGet("GetAllInstrumentation")]
        public ActionResult GetAllInstrumentation()
        {
            logger.LogInformation("Getting all Instrumentation");
            return new ObjectResult(inventoryService.GetAllInstrumentation());
        }

        [HttpGet("GetAllLabour")]
        public ActionResult GetAllLabour()
        {
            logger.LogInformation("Getting all Labour");
            return new ObjectResult(inventoryService.GetAllLabour());
        }

        [HttpGet("GetAllOther")]
        public ActionResult GetAllOther()
        {
            logger.LogInformation("Getting all Other");
            return new ObjectResult(inventoryService.GetAllOther());
        }

        [HttpGet("GetAllMonitoring")]
        public ActionResult GetAllMonitoring()
        {
            logger.LogInformation("Getting all Monitoring");
            return new ObjectResult(inventoryService.GetAllMonitoring());
        }

        [HttpGet("GetAllSwitchgear")]
        public ActionResult GetAllSwitchgear()
        {
            logger.LogInformation("Getting all Switchgear");
            return new ObjectResult(inventoryService.GetAllSwitchgear());
        }


        [HttpGet("GetAllInventoryItems")]
        public ActionResult GetAllInventoryItems()
        {
            logger.LogInformation("Getting all Inventory items");
            return new ObjectResult(inventoryService.GetAllInventoryItems());
        }
    }
}

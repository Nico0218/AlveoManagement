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

        [HttpGet("GetAllPLCItems")]
        public ActionResult GetAllPLCItems()
        {
            logger.LogInformation("Getting all PLC items");
            return new ObjectResult(inventoryService.GetAllPLCItems());
        }

        [HttpGet("GetAllHMIItems")]
        public ActionResult GetAllHMIItems()
        {
            logger.LogInformation("Getting all HMI items");
            return new ObjectResult(inventoryService.GetAllHMIItems());
        }

        [HttpGet("GetAllVSDItems")]
        public ActionResult GetAllVSDItems()
        {
            logger.LogInformation("Getting all VSD items");
            return new ObjectResult(inventoryService.GetAllVSDItems());
        }

        [HttpGet("GetAllRelayItems")]
        public ActionResult GetAllRelayItems()
        {
            logger.LogInformation("Getting all Relay items");
            return new ObjectResult(inventoryService.GetAllRelayItems());
        }

        [HttpGet("GetAllInventoryItems")]
        public ActionResult GetAllInventoryItems()
        {
            logger.LogInformation("Getting all Inventory items");
            return new ObjectResult(inventoryService.GetAllInventoryItems());
        }
    }
}

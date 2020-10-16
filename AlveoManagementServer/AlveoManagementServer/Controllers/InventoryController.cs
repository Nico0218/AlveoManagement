using AlveoManagementCommon.Classes;
using AlveoManagementCommon.Enums;
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

        [HttpGet("GetAllInventoryItems")]
        public ActionResult GetAllInventoryItems() {
            logger.LogInformation("Getting all Inventory items");
            return new ObjectResult(inventoryService.GetAllInventoryItems());
        }

        [HttpGet("GetInventoryItemsByCategory/{inventoryItemType}")]
        public ActionResult GetInventoryItemsByCategory(InventoryItemType inventoryItemType)
        {
            logger.LogInformation("Getting all Automation");
            return new ObjectResult(inventoryService.GetInventoryItemsByCategory(inventoryItemType));
        }

        [HttpPost("RemoveItemFromStock")]
        public ActionResult SaveProject(Item item)
        {
            logger.LogInformation("Removing Item From Stock");
            inventoryService.RemoveItemFromStock(item);
            return new ObjectResult("true");
        }
    }
}

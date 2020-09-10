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

        [HttpGet]
        public ActionResult Get()
        {
            logger.LogInformation("Getting all PLC items");
            return new ObjectResult(inventoryService.GetAllPLCItems());
        }
    }
}

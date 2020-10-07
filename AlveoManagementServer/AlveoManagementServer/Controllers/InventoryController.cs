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

        [HttpGet("GetAllContactors")]
        public ActionResult GetAllContactors()
        {
            logger.LogInformation("Getting all Contactors");
            return new ObjectResult(inventoryService.GetAllContactors());
        }

        [HttpGet("GetAllIsolators")]
        public ActionResult GetAllIsolators()
        {
            logger.LogInformation("Getting all Isolators");
            return new ObjectResult(inventoryService.GetAllIsolators());
        }

        [HttpGet("GetAllBrackets")]
        public ActionResult GetAllBrackets()
        {
            logger.LogInformation("Getting all Brackets");
            return new ObjectResult(inventoryService.GetAllBrackets());
        }

        [HttpGet("GetAllDistribution")]
        public ActionResult GetAllDistribution()
        {
            logger.LogInformation("Getting all Distribution");
            return new ObjectResult(inventoryService.GetAllDistribution());
        }

        [HttpGet("GetAllEthernet")]
        public ActionResult GetAllEthernet()
        {
            logger.LogInformation("Getting all Ethernet");
            return new ObjectResult(inventoryService.GetAllEthernet());
        }

        [HttpGet("GetAllFans")]
        public ActionResult GetAllFans()
        {
            logger.LogInformation("Getting all Fans");
            return new ObjectResult(inventoryService.GetAllFans());
        }

        [HttpGet("GetAllFlowmeters")]
        public ActionResult GetAllFlowmeters()
        {
            logger.LogInformation("Getting all Flowmeters");
            return new ObjectResult(inventoryService.GetAllFlowmeters());
        }

        [HttpGet("GetAllFuseholders")]
        public ActionResult GetAllFuseholders()
        {
            logger.LogInformation("Getting all Fuseholders");
            return new ObjectResult(inventoryService.GetAllFuseholders());
        }

        [HttpGet("GetAllMisc")]
        public ActionResult GetAllMisc()
        {
            logger.LogInformation("Getting all Misc");
            return new ObjectResult(inventoryService.GetAllMisc());
        }

        [HttpGet("GetAllPlcaux")]
        public ActionResult GetAllPlcaux()
        {
            logger.LogInformation("Getting all PLC Aux");
            return new ObjectResult(inventoryService.GetAllPlcaux());
        }

        [HttpGet("GetAllPsu")]
        public ActionResult GetAllPsu()
        {
            logger.LogInformation("Getting all Psu");
            return new ObjectResult(inventoryService.GetAllPsu());
        }

        [HttpGet("GetAllPanel")]
        public ActionResult GetAllPanel()
        {
            logger.LogInformation("Getting all Panel");
            return new ObjectResult(inventoryService.GetAllPanel());
        }

        [HttpGet("GetAllPlugs")]
        public ActionResult GetAllPlugs()
        {
            logger.LogInformation("Getting all Plugs");
            return new ObjectResult(inventoryService.GetAllPlugs());
        }

        [HttpGet("GetAllPower")]
        public ActionResult GetAllPower()
        {
            logger.LogInformation("Getting all Power");
            return new ObjectResult(inventoryService.GetAllPower());
        }

        [HttpGet("GetAllSensors")]
        public ActionResult GetAllSensors()
        {
            logger.LogInformation("Getting all Sensors");
            return new ObjectResult(inventoryService.GetAllSensors());
        }

        [HttpGet("GetAllStarters")]
        public ActionResult GetAllStarters()
        {
            logger.LogInformation("Getting all Starters");
            return new ObjectResult(inventoryService.GetAllStarters());
        }

        [HttpGet("GetAllSurge")]
        public ActionResult GetAllSurge()
        {
            logger.LogInformation("Getting all Surge");
            return new ObjectResult(inventoryService.GetAllSurge());
        }

        [HttpGet("GetAllSwitch")]
        public ActionResult GetAllSwitch()
        {
            logger.LogInformation("Getting all Switch");
            return new ObjectResult(inventoryService.GetAllSwitch());
        }

        [HttpGet("GetAllTransformer")]
        public ActionResult GetAllTransformer()
        {
            logger.LogInformation("Getting all Transformers");
            return new ObjectResult(inventoryService.GetAllTransformer());
        }

        [HttpGet("GetAllUps")]
        public ActionResult GetAllUps()
        {
            logger.LogInformation("Getting all Ups");
            return new ObjectResult(inventoryService.GetAllUps());
        }

        [HttpGet("GetAllVsdaux")]
        public ActionResult GetAllVsdaux()
        {
            logger.LogInformation("Getting all Vsd aux");
            return new ObjectResult(inventoryService.GetAllVsdaux());
        }



        [HttpGet("GetAllInventoryItems")]
        public ActionResult GetAllInventoryItems()
        {
            logger.LogInformation("Getting all Inventory items");
            return new ObjectResult(inventoryService.GetAllInventoryItems());
        }
    }
}

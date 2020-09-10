using AlveoManagementCommon.Classes;
using AlveoManagementServer.Services.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace AlveoManagementServer.Services
{
    public class InventoryService : IInventoryService
    {
        private readonly ILogger<InventoryService> logger;

        public InventoryService(ILogger<InventoryService> logger)
        {
            this.logger = logger;
        }

        public List<PlcItem> GetAllPLCItems()
        {
            logger.LogDebug("Getting all PLC items");
            List<PlcItem> plcItems = new List<PlcItem>();
            plcItems.Add(new PlcItem() { 
                ID = Guid.NewGuid().ToString(),
                Name = "S71212 DC/DC/DC",
                Make = "Siemens",
                PartNumber = "45665-5644-2852",
                Qty = 1
            });
            return plcItems;
        }
    }
}

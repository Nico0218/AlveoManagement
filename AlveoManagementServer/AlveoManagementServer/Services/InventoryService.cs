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
            plcItems.Add(new PlcItem()
            {
                ID = Guid.NewGuid().ToString(),
                Name = "S71212 DC/DC/DC",
                Make = "Siemens",
                PartNumber = "45665-5644-2852",
                Qty = 1,
                Description = "S71200 1212 plc",
                Unit = "ea",
                Rate = 8500,
                Req = 0
            }
            );
            plcItems.Add(new PlcItem()
            {
                ID = Guid.NewGuid().ToString(),
                Name = "S71214 DC/DC/DC",
                Make = "Siemens",
                PartNumber = "45665-5644-2852",
                Qty = 7,
                Description = "S71200 1214 plc",
                Unit = "ea",
                Rate = 9000,
                Req = 0
            }
            );
            plcItems.Add(new PlcItem()
            {
                ID = Guid.NewGuid().ToString(),
                Name = "S71211 DC/DC/DC",
                Make = "Siemens",
                PartNumber = "45665-5644-2852",
                Qty = 2,
                Description = "S71200 1211 plc",
                Unit = "ea",
                Rate = 7000,
                Req = 0
            }
            );
            plcItems.Add(new PlcItem()
            {
                ID = Guid.NewGuid().ToString(),
                Name = "S71215 DC/DC/DC",
                Make = "Siemens",
                PartNumber = "45665-5644-2852",
                Qty = 1,
                Description = "S71200 1215 plc",
                Unit = "ea",
                Rate = 11000,
                Req = 0
            }
            );
            plcItems.Add(new PlcItem()
            {
                ID = Guid.NewGuid().ToString(),
                Name = "S71217 DC/DC/DC",
                Make = "Siemens",
                PartNumber = "45665-5644-2852",
                Qty = 3,
                Description = "S71200 1217 plc",
                Unit = "ea",
                Rate = 12000,
                Req = 0
            }
            );
            plcItems.Add(new PlcItem()
            {
                ID = Guid.NewGuid().ToString(),
                Name = "S71512 DC/DC/DC",
                Make = "Siemens",
                PartNumber = "45665-5644-2852",
                Qty = 7,
                Description = "S71500 1512 plc",
                Unit = "ea",
                Rate = 17000,
                Req = 0
            }
            );
            plcItems.Add(new PlcItem()
            {
                ID = Guid.NewGuid().ToString(),
                Name = "S71515 DC/DC/DC",
                Make = "Siemens",
                PartNumber = "45665-5644-2852",
                Qty = 3,
                Description = "S71500 1515 plc",
                Unit = "ea",
                Rate = 19000,
                Req = 0
            }
            );
            plcItems.Add(new PlcItem()
            {
                ID = Guid.NewGuid().ToString(),
                Name = "S71517 DC/DC/DC",
                Make = "Siemens",
                PartNumber = "45665-5644-2852",
                Qty = 9,
                Description = "S71500 1517 plc",
                Unit = "ea",
                Rate = 23500,
                Req = 0
            }
            );
            plcItems.Add(new PlcItem()
            {
                ID = Guid.NewGuid().ToString(),
                Name = "S71212 Relay/Relay/Relay",
                Make = "Siemens",
                PartNumber = "45665-5644-2852",
                Qty = 1,
                Description = "S71200 1212 relay plc",
                Unit = "ea",
                Rate = 6500,
                Req = 0
            }
            );
            plcItems.Add(new PlcItem()
            {
                ID = Guid.NewGuid().ToString(),
                Name = "S71217 Relay/Relay/Relay",
                Make = "Siemens",
                PartNumber = "45665-5644-2852",
                Qty = 1,
                Description = "S71200 1217 relay plc",
                Unit = "ea",
                Rate = 8500,
                Req = 0
            }
            );
            plcItems.Add(new PlcItem()
            {
                ID = Guid.NewGuid().ToString(),
                Name = "S71215 Relay/Relay/Relay",
                Make = "Siemens",
                PartNumber = "45665-5644-2852",
                Qty = 8,
                Description = "S71200 1215 relay plc",
                Unit = "ea",
                Rate = 7500,
                Req = 0
            }
            );
            return plcItems;
        }

        public List<HmiItem> GetAllHMIItems()
        {
            logger.LogDebug("Getting all HMI items");
            List<HmiItem> hmiItems = new List<HmiItem>();
            hmiItems.Add(new HmiItem()
            {
                ID = Guid.NewGuid().ToString(),
                Name = "12' Basic Panel",
                Make = "Siemens",
                PartNumber = "45665-5644-2852",
                Qty = 1,
                Description = "12 inch Basic Panel",
                Unit = "ea",
                Rate = 25500,
                Req = 0
            }
            );
            hmiItems.Add(new HmiItem()
            {
                ID = Guid.NewGuid().ToString(),
                Name = "4' Basic Panel",
                Make = "Siemens",
                PartNumber = "45665-5644-2852",
                Qty = 5,
                Description = "4 inch Basic Panel",
                Unit = "ea",
                Rate = 7500,
                Req = 0
            }
            );
            hmiItems.Add(new HmiItem()
            {
                ID = Guid.NewGuid().ToString(),
                Name = "10' Basic Panel",
                Make = "Siemens",
                PartNumber = "45665-5644-2852",
                Qty = 7,
                Description = "10 inch Basic Panel",
                Unit = "ea",
                Rate = 15500,
                Req = 0
            }
            );
            hmiItems.Add(new HmiItem()
            {
                ID = Guid.NewGuid().ToString(),
                Name = "7' Basic Panel",
                Make = "Siemens",
                PartNumber = "45665-5644-2852",
                Qty = 6,
                Description = "7 inch Basic Panel",
                Unit = "ea",
                Rate = 11500,
                Req = 0
            }
            );
            return hmiItems;
        }

        public List<VsdItem> GetAllVSDItems()
        {
            logger.LogDebug("Getting all VSD items");
            List<VsdItem> vsdItems = new List<VsdItem>();
            vsdItems.Add(new VsdItem()
            {
                ID = Guid.NewGuid().ToString(),
                Name = "G120x",
                Make = "Siemens",
                PartNumber = "45665-5644-2852",
                Qty = 3,
                Description = "G120x VSD 5.5kw",
                Unit = "ea",
                Rate = 11500,
                Req = 0
            }
            );
            vsdItems.Add(new VsdItem()
            {
                ID = Guid.NewGuid().ToString(),
                Name = "V20",
                Make = "Siemens",
                PartNumber = "45665-5644-2852",
                Qty = 2,
                Description = "V20 vsd 0.75kw",
                Unit = "ea",
                Rate = 1200,
                Req = 0
            }
            );
            vsdItems.Add(new VsdItem()
            {
                ID = Guid.NewGuid().ToString(),
                Name = "G120C",
                Make = "Siemens",
                PartNumber = "45665-5644-2852",
                Qty = 1,
                Description = "G120c vsd 20kw",
                Unit = "ea",
                Rate = 25500,
                Req = 0
            }
            );
            return vsdItems;
        }
        public InventoryItems GetAllInventoryItems()
        {
            InventoryItems inventoryItems = new InventoryItems();
            inventoryItems.Plcs = GetAllPLCItems();
            inventoryItems.Hmis = GetAllHMIItems();
            inventoryItems.Vsds = GetAllVSDItems();
            return inventoryItems;
        }
    }
}

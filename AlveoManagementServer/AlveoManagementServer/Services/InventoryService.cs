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
                Qty = 1
            }
            );
            plcItems.Add(new PlcItem()
            {
                ID = Guid.NewGuid().ToString(),
                Name = "S71214 DC/DC/DC",
                Make = "Siemens",
                PartNumber = "45665-5644-2852",
                Qty = 7
            }
            );
            plcItems.Add(new PlcItem()
            {
                ID = Guid.NewGuid().ToString(),
                Name = "S71211 DC/DC/DC",
                Make = "Siemens",
                PartNumber = "45665-5644-2852",
                Qty = 2
            }
            );
            plcItems.Add(new PlcItem()
            {
                ID = Guid.NewGuid().ToString(),
                Name = "S71215 DC/DC/DC",
                Make = "Siemens",
                PartNumber = "45665-5644-2852",
                Qty = 1
            }
            );
            plcItems.Add(new PlcItem()
            {
                ID = Guid.NewGuid().ToString(),
                Name = "S71217 DC/DC/DC",
                Make = "Siemens",
                PartNumber = "45665-5644-2852",
                Qty = 3
            }
            );
            plcItems.Add(new PlcItem()
            {
                ID = Guid.NewGuid().ToString(),
                Name = "S71512 DC/DC/DC",
                Make = "Siemens",
                PartNumber = "45665-5644-2852",
                Qty = 7
            }
            );
            plcItems.Add(new PlcItem()
            {
                ID = Guid.NewGuid().ToString(),
                Name = "S71515 DC/DC/DC",
                Make = "Siemens",
                PartNumber = "45665-5644-2852",
                Qty = 3
            }
            );
            plcItems.Add(new PlcItem()
            {
                ID = Guid.NewGuid().ToString(),
                Name = "S71517 DC/DC/DC",
                Make = "Siemens",
                PartNumber = "45665-5644-2852",
                Qty = 9
            }
            );
            plcItems.Add(new PlcItem()
            {
                ID = Guid.NewGuid().ToString(),
                Name = "S71212 Relay/Relay/Relay",
                Make = "Siemens",
                PartNumber = "45665-5644-2852",
                Qty = 1
            }
            );
            plcItems.Add(new PlcItem()
            {
                ID = Guid.NewGuid().ToString(),
                Name = "S71217 Relay/Relay/Relay",
                Make = "Siemens",
                PartNumber = "45665-5644-2852",
                Qty = 1
            }
            );
            plcItems.Add(new PlcItem()
            {
                ID = Guid.NewGuid().ToString(),
                Name = "S71215 Relay/Relay/Relay",
                Make = "Siemens",
                PartNumber = "45665-5644-2852",
                Qty = 8
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
                Qty = 1
            }
            );
            hmiItems.Add(new HmiItem()
            {
                ID = Guid.NewGuid().ToString(),
                Name = "4' Basic Panel",
                Make = "Siemens",
                PartNumber = "45665-5644-2852",
                Qty = 5
            }
            );
            hmiItems.Add(new HmiItem()
            {
                ID = Guid.NewGuid().ToString(),
                Name = "10' Basic Panel",
                Make = "Siemens",
                PartNumber = "45665-5644-2852",
                Qty = 7
            }
            );
            hmiItems.Add(new HmiItem()
            {
                ID = Guid.NewGuid().ToString(),
                Name = "7' Basic Panel",
                Make = "Siemens",
                PartNumber = "45665-5644-2852",
                Qty = 6
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
                Qty = 3
            }
            );
            vsdItems.Add(new VsdItem()
            {
                ID = Guid.NewGuid().ToString(),
                Name = "V20",
                Make = "Siemens",
                PartNumber = "45665-5644-2852",
                Qty = 2
            }
            );
            vsdItems.Add(new VsdItem()
            {
                ID = Guid.NewGuid().ToString(),
                Name = "G120C",
                Make = "Siemens",
                PartNumber = "45665-5644-2852",
                Qty = 1
            }
            );
            return vsdItems;
        }
    }
}

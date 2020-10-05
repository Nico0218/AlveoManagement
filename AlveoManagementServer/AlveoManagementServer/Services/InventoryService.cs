using AlveoManagementCommon.Classes;
using AlveoManagementServer.Services.Interfaces;
using AlveoManagementServer.SQLite;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace AlveoManagementServer.Services
{
    public class InventoryService : IInventoryService
    {
        private readonly ILogger<InventoryService> logger;

        public InventoryService(ILogger<InventoryService> logger)
        {
            this.logger = logger;
        }

        Database databaseObject = new Database();

        public List<PlcItem> GetAllPLCItems()
        {
            logger.LogDebug("Getting all PLC items");
            List<PlcItem> plcItems = new List<PlcItem>();
            string selectPLC = "SELECT * FROM Customers";
            SQLiteCommand selectCommand = new SQLiteCommand(selectPLC, databaseObject.dataConnection);
            databaseObject.OpenConnection();
            SQLiteDataReader selectResult = selectCommand.ExecuteReader();
            if (selectResult.HasRows)
            {
                while (selectResult.Read())
                {
                    Console.WriteLine("name: {0} - customerID: {1}", selectResult["name"], selectResult["custID"]);
                    plcItems.Add(new PlcItem()
                    {
                        ID = (int)(Int64)selectResult["id"],
                        Name = (string)selectResult["name"],
                        Make = (string)selectResult["make"],
                        PartNumber = (string)selectResult["partNumber"],
                        Qty = (int)(Int64)selectResult["qty"],
                        Description = (string)selectResult["description"],
                        Unit = (string)selectResult["unit"],
                        Rate = (int)selectResult["Rate"],
                        Req = (int)selectResult["req"]
                    }
                    );
                    Console.WriteLine("done");
                }
            }
            databaseObject.CloseConnection();
            return plcItems;
        }

        public List<HmiItem> GetAllHMIItems()
        {
            logger.LogDebug("Getting all HMI items");
            List<HmiItem> hmiItems = new List<HmiItem>();
            hmiItems.Add(new HmiItem()
            {
                ID = 1,
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
                ID = 2,
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
                ID = 3,
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
                ID = 4,
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
                ID = 5,
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
                ID = 6,
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
                ID = 7,
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

        public List<RelayItem> GetAllRelayItems()
        {
            logger.LogDebug("Getting all Relay items");
            List<RelayItem> relayItems = new List<RelayItem>();
            relayItems.Add(new RelayItem()
            {
                ID = 1,
                Name = "2ch 24VDC Relay",
                Make = "Siemens",
                PartNumber = "LZS:RT4A4L24",
                Qty = 3,
                Description = "2 ch 24VDC relay - compete unit",
                Unit = "ea",
                Rate = 255,
                Req = 0
            }
            );
            relayItems.Add(new RelayItem()
            {
                ID = 2,
                Name = "2ch 220vac Relay",
                Make = "Siemens",
                PartNumber = "LZS:RT4A4L220",
                Qty = 2,
                Description = "2 ch 220VAC relay - compete unit",
                Unit = "ea",
                Rate = 270,
                Req = 0
            }
            );
            relayItems.Add(new RelayItem()
            {
                ID = 3,
                Name = "4ch 24vdc relay",
                Make = "Siemens",
                PartNumber = "LZS:RT8A8L24",
                Qty = 1,
                Description = "4 ch 24VDC relay - compete unit",
                Unit = "ea",
                Rate = 25500,
                Req = 0
            }
            );
            return relayItems;
        }


        public InventoryItems GetAllInventoryItems()
        {
            InventoryItems inventoryItems = new InventoryItems();
            inventoryItems.Plcs = GetAllPLCItems();
            inventoryItems.Hmis = GetAllHMIItems();
            inventoryItems.Vsds = GetAllVSDItems();
            inventoryItems.Relays = GetAllRelayItems();
            return inventoryItems;
        }
    }
}

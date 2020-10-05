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
            string selectPLC = "SELECT * FROM PLCItems";
            SQLiteCommand selectCommand = new SQLiteCommand(selectPLC, databaseObject.dataConnection);
            databaseObject.OpenConnection();
            SQLiteDataReader selectResult = selectCommand.ExecuteReader();
            if (selectResult.HasRows)
            {
                while (selectResult.Read())
                {
                    plcItems.Add(new PlcItem()
                    {
                        ID = (Int32)(Int64)selectResult["id"],
                        Name = (string)selectResult["name"],
                        Make = (string)selectResult["make"],
                        PartNumber = (string)selectResult["partNumber"],
                        Qty = (Int32)(Int64)selectResult["qty"],
                        Description = (string)selectResult["description"],
                        Unit = (string)selectResult["unit"],
                        Rate = (double)selectResult["Rate"],
                        Req = (Int32)(Int64)selectResult["req"]
                    }
                    );
                }
            }
            databaseObject.CloseConnection();
            return plcItems;
        }

        public List<HmiItem> GetAllHMIItems()
        {
            logger.LogDebug("Getting all HMI items");
            List<HmiItem> hmiItems = new List<HmiItem>();
            string selectHMI = "SELECT * FROM HMIItems";
            SQLiteCommand selectCommand = new SQLiteCommand(selectHMI, databaseObject.dataConnection);
            databaseObject.OpenConnection();
            SQLiteDataReader selectResult = selectCommand.ExecuteReader();
            if (selectResult.HasRows)
            {
                while (selectResult.Read())
                {
                    hmiItems.Add(new HmiItem()
                    {
                        ID = (Int32)(Int64)selectResult["id"],
                        Name = (string)selectResult["name"],
                        Make = (string)selectResult["make"],
                        PartNumber = (string)selectResult["partNumber"],
                        Qty = (Int32)(Int64)selectResult["qty"],
                        Description = (string)selectResult["description"],
                        Unit = (string)selectResult["unit"],
                        Rate = (double)selectResult["Rate"],
                        Req = (Int32)(Int64)selectResult["req"]
                    }
                    );
                }
            }
            databaseObject.CloseConnection();
            return hmiItems;
        }

        public List<VsdItem> GetAllVSDItems()
        {
            logger.LogDebug("Getting all VSD items");
            List<VsdItem> vsdItems = new List<VsdItem>();
            string selectVSD = "SELECT * FROM VSDItems";
            SQLiteCommand selectCommand = new SQLiteCommand(selectVSD, databaseObject.dataConnection);
            databaseObject.OpenConnection();
            SQLiteDataReader selectResult = selectCommand.ExecuteReader();
            if (selectResult.HasRows)
            {
                while (selectResult.Read())
                {
                    vsdItems.Add(new VsdItem()
                    {
                        ID = (Int32)(Int64)selectResult["id"],
                        Name = (string)selectResult["name"],
                        Make = (string)selectResult["make"],
                        PartNumber = (string)selectResult["partNumber"],
                        Qty = (Int32)(Int64)selectResult["qty"],
                        Description = (string)selectResult["description"],
                        Unit = (string)selectResult["unit"],
                        Rate = (double)selectResult["Rate"],
                        Req = (Int32)(Int64)selectResult["req"]
                    }
                    );
                }
            }
            databaseObject.CloseConnection();
            return vsdItems;
        }

        public List<RelayItem> GetAllRelayItems()
        {
            logger.LogDebug("Getting all Relay items");
            List<RelayItem> relayItems = new List<RelayItem>();
            string selectRelay = "SELECT * FROM VSDItems";
            SQLiteCommand selectCommand = new SQLiteCommand(selectRelay, databaseObject.dataConnection);
            databaseObject.OpenConnection();
            SQLiteDataReader selectResult = selectCommand.ExecuteReader();
            if (selectResult.HasRows)
            {
                while (selectResult.Read())
                {
                    relayItems.Add(new RelayItem()
                    {
                        ID = (Int32)(Int64)selectResult["id"],
                        Name = (string)selectResult["name"],
                        Make = (string)selectResult["make"],
                        PartNumber = (string)selectResult["partNumber"],
                        Qty = (Int32)(Int64)selectResult["qty"],
                        Description = (string)selectResult["description"],
                        Unit = (string)selectResult["unit"],
                        Rate = (double)selectResult["Rate"],
                        Req = (Int32)(Int64)selectResult["req"]
                    }
                    );
                    Console.WriteLine("done");
                }
            }
            databaseObject.CloseConnection();
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

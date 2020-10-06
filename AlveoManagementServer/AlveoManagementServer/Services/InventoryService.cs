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

        public List<Item> GetAllPLCItems()
        {
            logger.LogDebug("Getting all PLC items");
            List<Item> plcItems = new List<Item>();
            string selectPLC = "SELECT * FROM PLCItems";
            SQLiteCommand selectCommand = new SQLiteCommand(selectPLC, databaseObject.dataConnection);
            databaseObject.OpenConnection();
            SQLiteDataReader selectResult = selectCommand.ExecuteReader();
            if (selectResult.HasRows)
            {
                while (selectResult.Read())
                {
                    plcItems.Add(new Item()
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

        public List<Item> GetAllHMIItems()
        {
            logger.LogDebug("Getting all HMI items");
            List<Item> hmiItems = new List<Item>();
            string selectHMI = "SELECT * FROM HMIItems";
            SQLiteCommand selectCommand = new SQLiteCommand(selectHMI, databaseObject.dataConnection);
            databaseObject.OpenConnection();
            SQLiteDataReader selectResult = selectCommand.ExecuteReader();
            if (selectResult.HasRows)
            {
                while (selectResult.Read())
                {
                    hmiItems.Add(new Item()
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

        public List<Item> GetAllVSDItems()
        {
            logger.LogDebug("Getting all VSD items");
            List<Item> vsdItems = new List<Item>();
            string selectVSD = "SELECT * FROM VSDItems";
            SQLiteCommand selectCommand = new SQLiteCommand(selectVSD, databaseObject.dataConnection);
            databaseObject.OpenConnection();
            SQLiteDataReader selectResult = selectCommand.ExecuteReader();
            if (selectResult.HasRows)
            {
                while (selectResult.Read())
                {
                    vsdItems.Add(new Item()
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

        public List<Item> GetAllRelayItems()
        {
            logger.LogDebug("Getting all Relay items");
            List<Item> relayItems = new List<Item>();
            string selectRelay = "SELECT * FROM VSDItems";
            SQLiteCommand selectCommand = new SQLiteCommand(selectRelay, databaseObject.dataConnection);
            databaseObject.OpenConnection();
            SQLiteDataReader selectResult = selectCommand.ExecuteReader();
            if (selectResult.HasRows)
            {
                while (selectResult.Read())
                {
                    relayItems.Add(new Item()
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

        public List<Item> GetAllContactors()
        {
            logger.LogDebug("Getting all Contactor items");
            List<Item> contactors = new List<Item>();
            string selectContactor = "SELECT * FROM Contactors";
            SQLiteCommand selectCommand = new SQLiteCommand(selectContactor, databaseObject.dataConnection);
            databaseObject.OpenConnection();
            SQLiteDataReader selectResult = selectCommand.ExecuteReader();
            if (selectResult.HasRows)
            {
                while (selectResult.Read())
                {
                    contactors.Add(new Item()
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
            return contactors;
        }

        public List<Item> GetAllIsolators()
        {
            logger.LogDebug("Getting all Isolators");
            List<Item> isolators = new List<Item>();
            string selectIsolator = "SELECT * FROM Isolators";
            SQLiteCommand selectCommand = new SQLiteCommand(selectIsolator, databaseObject.dataConnection);
            databaseObject.OpenConnection();
            SQLiteDataReader selectResult = selectCommand.ExecuteReader();
            if (selectResult.HasRows)
            {
                while (selectResult.Read())
                {
                    isolators.Add(new Item()
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
            return isolators;
        }


        public InventoryItems GetAllInventoryItems()
        {
            InventoryItems inventoryItems = new InventoryItems();
            inventoryItems.Plcs = GetAllPLCItems();
            inventoryItems.Hmis = GetAllHMIItems();
            inventoryItems.Vsds = GetAllVSDItems();
            inventoryItems.Relays = GetAllRelayItems();
            inventoryItems.Contactors = GetAllContactors();
            return inventoryItems;
        }
    }
}

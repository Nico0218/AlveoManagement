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

        public List<Item> GetAllAutomation()
        {
            logger.LogDebug("Getting all Automation");
            List<Item> automation = new List<Item>();
            string selectAutomation = "SELECT * FROM Automation";
            SQLiteCommand selectCommand = new SQLiteCommand(selectAutomation, databaseObject.dataConnection);
            databaseObject.OpenConnection();
            SQLiteDataReader selectResult = selectCommand.ExecuteReader();
            if (selectResult.HasRows)
            {
                while (selectResult.Read())
                {
                    automation.Add(new Item()
                    {
                        ID = (Int32)(Int64)selectResult["id"],
                        Name = (string)selectResult["name"],
                        Supplier = (string)selectResult["supplier"],
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
            return automation;
        }

        public List<Item> GetAllCabletrays()
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

        public List<Item> GetAllExtras()
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

        public List<Item> GetAllInstrumentation()
        {
            logger.LogDebug("Getting all Relay items");
            List<Item> relayItems = new List<Item>();
            string selectRelay = "SELECT * FROM RelayItems";
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

        public List<Item> GetAllLabour()
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

        public List<Item> GetAllOther()
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

        public List<Item> GetAllMonitoring()
        {
            logger.LogDebug("Getting all Brackets");
            List<Item> brackets = new List<Item>();
            string selectBrackets = "SELECT * FROM Brackets";
            SQLiteCommand selectCommand = new SQLiteCommand(selectBrackets, databaseObject.dataConnection);
            databaseObject.OpenConnection();
            SQLiteDataReader selectResult = selectCommand.ExecuteReader();
            if (selectResult.HasRows)
            {
                while (selectResult.Read())
                {
                    brackets.Add(new Item()
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
            return brackets;
        }

        public List<Item> GetAllSwitchgear()
        {
            logger.LogDebug("Getting all Distribution");
            List<Item> distribution = new List<Item>();
            string selectBrackets = "SELECT * FROM Distribution";
            SQLiteCommand selectCommand = new SQLiteCommand(selectBrackets, databaseObject.dataConnection);
            databaseObject.OpenConnection();
            SQLiteDataReader selectResult = selectCommand.ExecuteReader();
            if (selectResult.HasRows)
            {
                while (selectResult.Read())
                {
                    distribution.Add(new Item()
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
            return distribution;
        }


        public InventoryItems GetAllInventoryItems()
        {
            InventoryItems inventoryItems = new InventoryItems();
            inventoryItems.Automation = GetAllAutomation();
            inventoryItems.Cabletrays = GetAllCabletrays();
            inventoryItems.Extras = GetAllExtras();
            inventoryItems.Instrumentation = GetAllInstrumentation();
            inventoryItems.Labour = GetAllLabour();
            inventoryItems.Other = GetAllOther();
            inventoryItems.Monitoring = GetAllMonitoring();
            inventoryItems.Switchgear = GetAllSwitchgear();
            return inventoryItems;
        }
    }
}

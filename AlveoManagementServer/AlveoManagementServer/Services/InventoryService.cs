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
                        PartNumber = (string)selectResult["partnumber"],
                        Cost = (double)selectResult["cost"],
                        Instock = (Int32)(Int64)selectResult["instock"],
                        Req = (Int32)(Int64)selectResult["req"],
                        Unit = (string)selectResult["unit"],
                        Category = "Automation"
                    }
                    );
                }
            }
            databaseObject.CloseConnection();
            return automation;
        }

        public List<Item> GetAllCabletrays()
        {
            logger.LogDebug("Getting all Cables and trays");
            List<Item> cable = new List<Item>();
            string selectCT = "SELECT * FROM Cabletrays";
            SQLiteCommand selectCommand = new SQLiteCommand(selectCT, databaseObject.dataConnection);
            databaseObject.OpenConnection();
            SQLiteDataReader selectResult = selectCommand.ExecuteReader();
            if (selectResult.HasRows)
            {
                while (selectResult.Read())
                {
                    cable.Add(new Item()
                    {
                        ID = (Int32)(Int64)selectResult["id"],
                        Name = (string)selectResult["name"],
                        Supplier = (string)selectResult["supplier"],
                        PartNumber = (string)selectResult["partnumber"],
                        Cost = (double)selectResult["cost"],
                        Instock = (Int32)(Int64)selectResult["instock"],
                        Req = (Int32)(Int64)selectResult["req"],
                        Unit = (string)selectResult["unit"],
                        Category = "Cabletrays"
                    }
                    );
                }
            }
            databaseObject.CloseConnection();
            return cable;
        }

        public List<Item> GetAllExtras()
        {
            logger.LogDebug("Getting all Extras");
            List<Item> extras = new List<Item>();
            string selectExtras = "SELECT * FROM Extras";
            SQLiteCommand selectCommand = new SQLiteCommand(selectExtras, databaseObject.dataConnection);
            databaseObject.OpenConnection();
            SQLiteDataReader selectResult = selectCommand.ExecuteReader();
            if (selectResult.HasRows)
            {
                while (selectResult.Read())
                {
                    extras.Add(new Item()
                    {
                        ID = (Int32)(Int64)selectResult["id"],
                        Name = (string)selectResult["name"],
                        Supplier = (string)selectResult["supplier"],
                        PartNumber = (string)selectResult["partnumber"],
                        Cost = (double)selectResult["cost"],
                        Instock = (Int32)(Int64)selectResult["instock"],
                        Req = (Int32)(Int64)selectResult["req"],
                        Unit = (string)selectResult["unit"],
                        Category = "Extras"
                    }
                    );
                }
            }
            databaseObject.CloseConnection();
            return extras;
        }

        public List<Item> GetAllInstrumentation()
        {
            logger.LogDebug("Getting all Instrumentation");
            List<Item> instrumentation = new List<Item>();
            string selectInstrumentation = "SELECT * FROM Instrumentation";
            SQLiteCommand selectCommand = new SQLiteCommand(selectInstrumentation, databaseObject.dataConnection);
            databaseObject.OpenConnection();
            SQLiteDataReader selectResult = selectCommand.ExecuteReader();
            if (selectResult.HasRows)
            {
                while (selectResult.Read())
                {
                    instrumentation.Add(new Item()
                    {
                        ID = (Int32)(Int64)selectResult["id"],
                        Name = (string)selectResult["name"],
                        Supplier = (string)selectResult["supplier"],
                        PartNumber = (string)selectResult["partnumber"],
                        Cost = (double)selectResult["cost"],
                        Instock = (Int32)(Int64)selectResult["instock"],
                        Req = (Int32)(Int64)selectResult["req"],
                        Unit = (string)selectResult["unit"],
                        Category = "Instrumentation"
                    }
                    );
                }
            }
            databaseObject.CloseConnection();
            return instrumentation;
        }

        public List<Item> GetAllLabour()
        {
            logger.LogDebug("Getting all Labour");
            List<Item> labour = new List<Item>();
            string selectLabour = "SELECT * FROM Labour";
            SQLiteCommand selectCommand = new SQLiteCommand(selectLabour, databaseObject.dataConnection);
            databaseObject.OpenConnection();
            SQLiteDataReader selectResult = selectCommand.ExecuteReader();
            if (selectResult.HasRows)
            {
                while (selectResult.Read())
                {
                    labour.Add(new Item()
                    {
                        ID = (Int32)(Int64)selectResult["id"],
                        Name = (string)selectResult["name"],
                        Supplier = (string)selectResult["supplier"],
                        PartNumber = (string)selectResult["partnumber"],
                        Cost = (double)selectResult["cost"],
                        Instock = (Int32)(Int64)selectResult["instock"],
                        Req = (Int32)(Int64)selectResult["req"],
                        Unit = (string)selectResult["unit"],
                        Category = "Labour"
                    }
                    );
                }
            }
            databaseObject.CloseConnection();
            return labour;
        }

        public List<Item> GetAllOther()
        {
            logger.LogDebug("Getting all Other");
            List<Item> other = new List<Item>();
            string selectOther = "SELECT * FROM Other";
            SQLiteCommand selectCommand = new SQLiteCommand(selectOther, databaseObject.dataConnection);
            databaseObject.OpenConnection();
            SQLiteDataReader selectResult = selectCommand.ExecuteReader();
            if (selectResult.HasRows)
            {
                while (selectResult.Read())
                {
                    other.Add(new Item()
                    {
                        ID = (Int32)(Int64)selectResult["id"],
                        Name = (string)selectResult["name"],
                        Supplier = (string)selectResult["supplier"],
                        PartNumber = (string)selectResult["partnumber"],
                        Cost = (double)selectResult["cost"],
                        Instock = (Int32)(Int64)selectResult["instock"],
                        Req = (Int32)(Int64)selectResult["req"],
                        Unit = (string)selectResult["unit"],
                        Category = "Other"
                    }
                    );
                }
            }
            databaseObject.CloseConnection();
            return other;
        }

        public List<Item> GetAllMonitoring()
        {
            logger.LogDebug("Getting all Monitoring");
            List<Item> monitoring = new List<Item>();
            string selectMonitoring = "SELECT * FROM Remotemonitoring";
            SQLiteCommand selectCommand = new SQLiteCommand(selectMonitoring, databaseObject.dataConnection);
            databaseObject.OpenConnection();
            SQLiteDataReader selectResult = selectCommand.ExecuteReader();
            if (selectResult.HasRows)
            {
                while (selectResult.Read())
                {
                    monitoring.Add(new Item()
                    {
                        ID = (Int32)(Int64)selectResult["id"],
                        Name = (string)selectResult["name"],
                        Supplier = (string)selectResult["supplier"],
                        PartNumber = (string)selectResult["partnumber"],
                        Cost = (double)selectResult["cost"],
                        Instock = (Int32)(Int64)selectResult["instock"],
                        Req = (Int32)(Int64)selectResult["req"],
                        Unit = (string)selectResult["unit"],
                        Category = "Monitoring"
                    }
                    );
                }
            }
            databaseObject.CloseConnection();
            return monitoring;
        }

        public List<Item> GetAllSwitchgear()
        {
            logger.LogDebug("Getting all Switchgear");
            List<Item> switchgear = new List<Item>();
            string selectSwitchgear = "SELECT * FROM Switchgear";
            SQLiteCommand selectCommand = new SQLiteCommand(selectSwitchgear, databaseObject.dataConnection);
            databaseObject.OpenConnection();
            SQLiteDataReader selectResult = selectCommand.ExecuteReader();
            if (selectResult.HasRows)
            {
                while (selectResult.Read())
                {
                    switchgear.Add(new Item()
                    {
                        ID = (Int32)(Int64)selectResult["id"],
                        Name = (string)selectResult["name"],
                        Supplier = (string)selectResult["supplier"],
                        PartNumber = (string)selectResult["partnumber"],
                        Cost = (double)selectResult["cost"],
                        Instock = (Int32)(Int64)selectResult["instock"],
                        Req = (Int32)(Int64)selectResult["req"],
                        Unit = (string)selectResult["unit"],
                        Category = "Switchgear"
                    }
                    );
                }
            }
            databaseObject.CloseConnection();
            return switchgear;
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

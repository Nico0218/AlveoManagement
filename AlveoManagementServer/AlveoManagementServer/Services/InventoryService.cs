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

        public List<Item> GetAllBrackets()
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

        public List<Item> GetAllDistribution()
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

        public List<Item> GetAllEthernet()
        {
            logger.LogDebug("Getting all Ethernet");
            List<Item> ethernet = new List<Item>();
            string selectEthernet = "SELECT * FROM Ethernet";
            SQLiteCommand selectCommand = new SQLiteCommand(selectEthernet, databaseObject.dataConnection);
            databaseObject.OpenConnection();
            SQLiteDataReader selectResult = selectCommand.ExecuteReader();
            if (selectResult.HasRows)
            {
                while (selectResult.Read())
                {
                    ethernet.Add(new Item()
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
            return ethernet;
        }

        public List<Item> GetAllFans()
        {
            logger.LogDebug("Getting all Fans");
            List<Item> fans = new List<Item>();
            string selectFans = "SELECT * FROM Fans";
            SQLiteCommand selectCommand = new SQLiteCommand(selectFans, databaseObject.dataConnection);
            databaseObject.OpenConnection();
            SQLiteDataReader selectResult = selectCommand.ExecuteReader();
            if (selectResult.HasRows)
            {
                while (selectResult.Read())
                {
                    fans.Add(new Item()
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
            return fans;
        }

        public List<Item> GetAllFlowmeters()
        {
            logger.LogDebug("Getting all Flowmeters");
            List<Item> flowmeters = new List<Item>();
            string selectFlowmeters = "SELECT * FROM Flowmeters";
            SQLiteCommand selectCommand = new SQLiteCommand(selectFlowmeters, databaseObject.dataConnection);
            databaseObject.OpenConnection();
            SQLiteDataReader selectResult = selectCommand.ExecuteReader();
            if (selectResult.HasRows)
            {
                while (selectResult.Read())
                {
                    flowmeters.Add(new Item()
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
            return flowmeters;
        }

        public List<Item> GetAllFuseholders()
        {
            logger.LogDebug("Getting all Fuseholders");
            List<Item> fuseholders = new List<Item>();
            string selectFuseholders= "SELECT * FROM Fuseholder";
            SQLiteCommand selectCommand = new SQLiteCommand(selectFuseholders, databaseObject.dataConnection);
            databaseObject.OpenConnection();
            SQLiteDataReader selectResult = selectCommand.ExecuteReader();
            if (selectResult.HasRows)
            {
                while (selectResult.Read())
                {
                    fuseholders.Add(new Item()
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
            return fuseholders;
        }

        public List<Item> GetAllMisc()
        {
            logger.LogDebug("Getting all Misc");
            List<Item> misc = new List<Item>();
            string selectMisc = "SELECT * FROM Misc";
            SQLiteCommand selectCommand = new SQLiteCommand(selectMisc, databaseObject.dataConnection);
            databaseObject.OpenConnection();
            SQLiteDataReader selectResult = selectCommand.ExecuteReader();
            if (selectResult.HasRows)
            {
                while (selectResult.Read())
                {
                    misc.Add(new Item()
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
            return misc;
        }

        public List<Item> GetAllPlcaux()
        {
            logger.LogDebug("Getting all Plcaux");
            List<Item> plcaux = new List<Item>();
            string selectPlcaux = "SELECT * FROM PLCAux";
            SQLiteCommand selectCommand = new SQLiteCommand(selectPlcaux, databaseObject.dataConnection);
            databaseObject.OpenConnection();
            SQLiteDataReader selectResult = selectCommand.ExecuteReader();
            if (selectResult.HasRows)
            {
                while (selectResult.Read())
                {
                    plcaux.Add(new Item()
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
            return plcaux;
        }

        public List<Item> GetAllPsu()
        {
            logger.LogDebug("Getting all Psu");
            List<Item> psu = new List<Item>();
            string selectPsu = "SELECT * FROM PSU";
            SQLiteCommand selectCommand = new SQLiteCommand(selectPsu, databaseObject.dataConnection);
            databaseObject.OpenConnection();
            SQLiteDataReader selectResult = selectCommand.ExecuteReader();
            if (selectResult.HasRows)
            {
                while (selectResult.Read())
                {
                    psu.Add(new Item()
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
            return psu;
        }

        public List<Item> GetAllPanel()
        {
            logger.LogDebug("Getting all Panels");
            List<Item> panels = new List<Item>();
            string selectPanels = "SELECT * FROM Panels";
            SQLiteCommand selectCommand = new SQLiteCommand(selectPanels, databaseObject.dataConnection);
            databaseObject.OpenConnection();
            SQLiteDataReader selectResult = selectCommand.ExecuteReader();
            if (selectResult.HasRows)
            {
                while (selectResult.Read())
                {
                    panels.Add(new Item()
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
            return panels;
        }

        public List<Item> GetAllPlugs()
        {
            logger.LogDebug("Getting all Plugs");
            List<Item> plugs = new List<Item>();
            string selectPlugs = "SELECT * FROM Plugs";
            SQLiteCommand selectCommand = new SQLiteCommand(selectPlugs, databaseObject.dataConnection);
            databaseObject.OpenConnection();
            SQLiteDataReader selectResult = selectCommand.ExecuteReader();
            if (selectResult.HasRows)
            {
                while (selectResult.Read())
                {
                    plugs.Add(new Item()
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
            return plugs;
        }

        public List<Item> GetAllPower()
        {
            logger.LogDebug("Getting all Power");
            List<Item> power = new List<Item>();
            string selectPower = "SELECT * FROM Powermonitoring";
            SQLiteCommand selectCommand = new SQLiteCommand(selectPower, databaseObject.dataConnection);
            databaseObject.OpenConnection();
            SQLiteDataReader selectResult = selectCommand.ExecuteReader();
            if (selectResult.HasRows)
            {
                while (selectResult.Read())
                {
                    power.Add(new Item()
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
            return power;
        }

        public List<Item> GetAllSensors()
        {
            logger.LogDebug("Getting all Sensors");
            List<Item> sensors = new List<Item>();
            string selectSensors = "SELECT * FROM Sensors";
            SQLiteCommand selectCommand = new SQLiteCommand(selectSensors, databaseObject.dataConnection);
            databaseObject.OpenConnection();
            SQLiteDataReader selectResult = selectCommand.ExecuteReader();
            if (selectResult.HasRows)
            {
                while (selectResult.Read())
                {
                    sensors.Add(new Item()
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
            return sensors;
        }

        public List<Item> GetAllStarters()
        {
            logger.LogDebug("Getting all Starters");
            List<Item> starters = new List<Item>();
            string selectStarters = "SELECT * FROM Softstarter";
            SQLiteCommand selectCommand = new SQLiteCommand(selectStarters, databaseObject.dataConnection);
            databaseObject.OpenConnection();
            SQLiteDataReader selectResult = selectCommand.ExecuteReader();
            if (selectResult.HasRows)
            {
                while (selectResult.Read())
                {
                    starters.Add(new Item()
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
            return starters;
        }

        public List<Item> GetAllSurge()
        {
            logger.LogDebug("Getting all Surge");
            List<Item> surge = new List<Item>();
            string selectSurge = "SELECT * FROM Surgearrestors";
            SQLiteCommand selectCommand = new SQLiteCommand(selectSurge, databaseObject.dataConnection);
            databaseObject.OpenConnection();
            SQLiteDataReader selectResult = selectCommand.ExecuteReader();
            if (selectResult.HasRows)
            {
                while (selectResult.Read())
                {
                    surge.Add(new Item()
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
            return surge;
        }

        public List<Item> GetAllSwitch()
        {
            logger.LogDebug("Getting all Switch");
            List<Item> switches = new List<Item>();
            string selectSwitch = "SELECT * FROM Switchgear";
            SQLiteCommand selectCommand = new SQLiteCommand(selectSwitch, databaseObject.dataConnection);
            databaseObject.OpenConnection();
            SQLiteDataReader selectResult = selectCommand.ExecuteReader();
            if (selectResult.HasRows)
            {
                while (selectResult.Read())
                {
                    switches.Add(new Item()
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
            return switches;
        }

        public List<Item> GetAllTransformer()
        {
            logger.LogDebug("Getting all Transformers");
            List<Item> transformers = new List<Item>();
            string selectTransformers = "SELECT * FROM Transformers";
            SQLiteCommand selectCommand = new SQLiteCommand(selectTransformers, databaseObject.dataConnection);
            databaseObject.OpenConnection();
            SQLiteDataReader selectResult = selectCommand.ExecuteReader();
            if (selectResult.HasRows)
            {
                while (selectResult.Read())
                {
                    transformers.Add(new Item()
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
            return transformers;
        }

        public List<Item> GetAllUps()
        {
            logger.LogDebug("Getting all Ups");
            List<Item> ups = new List<Item>();
            string selectUps = "SELECT * FROM UPS";
            SQLiteCommand selectCommand = new SQLiteCommand(selectUps, databaseObject.dataConnection);
            databaseObject.OpenConnection();
            SQLiteDataReader selectResult = selectCommand.ExecuteReader();
            if (selectResult.HasRows)
            {
                while (selectResult.Read())
                {
                    ups.Add(new Item()
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
            return ups;
        }

        public List<Item> GetAllVsdaux()
        {
            logger.LogDebug("Getting all VSD aux");
            List<Item> vsdaux = new List<Item>();
            string selectVsdaux = "SELECT * FROM VSDAux";
            SQLiteCommand selectCommand = new SQLiteCommand(selectVsdaux, databaseObject.dataConnection);
            databaseObject.OpenConnection();
            SQLiteDataReader selectResult = selectCommand.ExecuteReader();
            if (selectResult.HasRows)
            {
                while (selectResult.Read())
                {
                    vsdaux.Add(new Item()
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
            return vsdaux;
        }


        public InventoryItems GetAllInventoryItems()
        {
            InventoryItems inventoryItems = new InventoryItems();
            inventoryItems.Plcs = GetAllPLCItems();
            inventoryItems.Hmis = GetAllHMIItems();
            inventoryItems.Vsds = GetAllVSDItems();
            inventoryItems.Relays = GetAllRelayItems();
            inventoryItems.Contactors = GetAllContactors();
            inventoryItems.Isolators = GetAllIsolators();
            inventoryItems.Brackets = GetAllBrackets();
            inventoryItems.Distribution = GetAllDistribution();
            inventoryItems.Ethernet = GetAllEthernet();
            inventoryItems.Fans = GetAllFans();
            inventoryItems.Flowmeters = GetAllFlowmeters();
            inventoryItems.Fuseholders = GetAllFuseholders();
            inventoryItems.Misc = GetAllMisc();
            inventoryItems.Plcaux = GetAllPlcaux();
            inventoryItems.Psu = GetAllPsu();
            inventoryItems.Panels = GetAllPanel();
            inventoryItems.Plugs = GetAllPlugs();
            inventoryItems.Power = GetAllPower();
            inventoryItems.Sensors = GetAllSensors();
            inventoryItems.Starters = GetAllStarters();
            inventoryItems.Surge = GetAllSurge();
            inventoryItems.Switchgear = GetAllSwitch();
            inventoryItems.Transformers = GetAllTransformer();
            inventoryItems.Ups = GetAllUps();
            inventoryItems.Vsdaux = GetAllVsdaux();
            return inventoryItems;
        }
    }
}

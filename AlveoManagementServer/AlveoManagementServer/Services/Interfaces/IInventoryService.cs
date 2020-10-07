using AlveoManagementCommon.Classes;
using System.Collections.Generic;

namespace AlveoManagementServer.Services.Interfaces
{
    public interface IInventoryService
    {
        List<Item> GetAllPLCItems();
        List<Item> GetAllHMIItems();
        List<Item> GetAllVSDItems();
        List<Item> GetAllRelayItems();
        List<Item> GetAllContactors();
        List<Item> GetAllIsolators();
        List<Item> GetAllBrackets();
        List<Item> GetAllDistribution();
        List<Item> GetAllEthernet();
        List<Item> GetAllFans();
        List<Item> GetAllFlowmeters();
        List<Item> GetAllFuseholders();
        List<Item> GetAllMisc();
        List<Item> GetAllPlcaux();
        List<Item> GetAllPsu();
        List<Item> GetAllPanel();
        List<Item> GetAllPlugs();
        List<Item> GetAllPower();
        List<Item> GetAllSensors();
        List<Item> GetAllStarters();
        List<Item> GetAllSurge();
        List<Item> GetAllSwitch();
        List<Item> GetAllTransformer();
        List<Item> GetAllUps();
        List<Item> GetAllVsdaux();
        InventoryItems GetAllInventoryItems();
    }
}

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
        InventoryItems GetAllInventoryItems();
    }
}

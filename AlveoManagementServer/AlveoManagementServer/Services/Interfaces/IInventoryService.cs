using AlveoManagementCommon.Classes;
using System.Collections.Generic;

namespace AlveoManagementServer.Services.Interfaces
{
    public interface IInventoryService
    {
        List<PlcItem> GetAllPLCItems();
        List<HmiItem> GetAllHMIItems();
        List<VsdItem> GetAllVSDItems();
        List<RelayItem> GetAllRelayItems();
        InventoryItems GetAllInventoryItems();
    }
}

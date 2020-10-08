using AlveoManagementCommon.Classes;
using System.Collections.Generic;

namespace AlveoManagementServer.Services.Interfaces
{
    public interface IInventoryService
    {
        List<Item> GetAllAutomation();
        List<Item> GetAllCabletrays();
        List<Item> GetAllExtras();
        List<Item> GetAllInstrumentation();
        List<Item> GetAllLabour();
        List<Item> GetAllOther();
        List<Item> GetAllMonitoring();
        List<Item> GetAllSwitchgear();
        InventoryItems GetAllInventoryItems();
    }
}

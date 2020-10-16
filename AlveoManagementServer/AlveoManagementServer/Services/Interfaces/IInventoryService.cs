using AlveoManagementCommon.Classes;
using AlveoManagementCommon.Enums;
using System.Collections.Generic;

namespace AlveoManagementServer.Services.Interfaces {
    public interface IInventoryService {
        InventoryItems GetAllInventoryItems();
        List<Item> GetInventoryItemsByCategory(InventoryItemType inventoryItemType);
        void RemoveItemFromStock (Item item);
    }
}

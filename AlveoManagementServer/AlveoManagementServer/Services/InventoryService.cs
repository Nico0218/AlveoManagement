using AlveoManagementCommon.Classes;
using AlveoManagementCommon.Enums;
using AlveoManagementServer.Services.Interfaces;
using DBProviderBase.Classes;
using DBProviderBase.Interfaces;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace AlveoManagementServer.Services {
    public class InventoryService : IInventoryService
    {
        private readonly ILogger<InventoryService> logger;
        private readonly IDataService dataService;

        public InventoryService(ILogger<InventoryService> logger, IDataService dataService)
        {
            this.logger = logger;
            this.dataService = dataService;
        }

        public InventoryItems GetAllInventoryItems() {
            List<Item> items = dataService.GetObjectData<Item>();
            InventoryItems inventoryItems = new InventoryItems();
            inventoryItems.Automation = items.FindAll(ii => ii.Category == InventoryItemType.Automation);
            inventoryItems.Cabletrays = items.FindAll(ii => ii.Category == InventoryItemType.CableTrays);
            inventoryItems.Extras = items.FindAll(ii => ii.Category == InventoryItemType.Extras);
            inventoryItems.Instrumentation = items.FindAll(ii => ii.Category == InventoryItemType.Instumentation);
            inventoryItems.Labour = items.FindAll(ii => ii.Category == InventoryItemType.Labour);
            inventoryItems.Other = items.FindAll(ii => ii.Category == InventoryItemType.Other);
            inventoryItems.Monitoring = items.FindAll(ii => ii.Category == InventoryItemType.RemoteMonitoring);
            inventoryItems.Switchgear = items.FindAll(ii => ii.Category == InventoryItemType.Switchgear);
            return inventoryItems;
        }

        public List<Item> GetInventoryItemsByCategory(InventoryItemType inventoryItemType)
        {
            logger.LogDebug("Getting all Cables and trays");
            List<IParameter> parameters = new List<IParameter>();
            parameters.Add(new Parameter() { ColumnName = "Category", DataType = "System.Int", Operator = DBProviderBase.Enums.ParamOperator.Equals, Value = inventoryItemType.ToString() });
            return dataService.GetObjectData<Item>(parameters);
        }
    }
}

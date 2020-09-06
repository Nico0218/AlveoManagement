import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { InventoryItem } from '../models/inventory/inventory-item';
import { Guid } from '../classes/guid';
import { InventoryType } from '../models/inventory/inventory-type';

@Injectable()
export class InventoryService {
  public GetAllInventoryItems(): Observable<InventoryItem[]> {
    //https://www.learnrxjs.io/learn-rxjs/operators/creation/of
    return of(this.getData()); // We wrap our data in an Observable here - Note at this point the Observable has not "Run" yet
  }

  //Temp method to fill data that will be retrieved from the backend API
  private getData() {
    var ItemData: InventoryItem[] = [];

    //PLCc
    var inventoryItem = this.buildInventoryItem("PLCs", "Siemens");
    var type = this.buildInventoryType("S71212 DC/DC/DC", "1258-456875-123145", 1);
    inventoryItem.Types.push(type);
    type = this.buildInventoryType("S71214C DC/DC/DC", "1234654-4641-412314", 3);
    inventoryItem.Types.push(type);
    type = this.buildInventoryType("S71517", "213654-23145612-123124", 1);
    inventoryItem.Types.push(type);
    ItemData.push(inventoryItem);

    //HMI's
    inventoryItem = this.buildInventoryItem("HMI's", "Siemens");
    var type = this.buildInventoryType("12' Comfort", "1235423-1234534123-453457748", 10);
    inventoryItem.Types.push(type);
    type = this.buildInventoryType("7' Basic", "45612345-45682423-45645213", 9);
    inventoryItem.Types.push(type);
    type = this.buildInventoryType("15' Comfort", "123486-45645313-456423", 5);
    inventoryItem.Types.push(type);
    ItemData.push(inventoryItem);

    //VSD's
    inventoryItem = this.buildInventoryItem("VSD's", "Siemens");
    var type = this.buildInventoryType("G120x", "45354678-41234561-24674", 8);
    inventoryItem.Types.push(type);
    type = this.buildInventoryType("V20", "45648645465-456453213-45645", 6);
    inventoryItem.Types.push(type);
    type = this.buildInventoryType("G120c", "1234556-1234564", 7);
    inventoryItem.Types.push(type);
    ItemData.push(inventoryItem);

    //Contactor's
    inventoryItem = this.buildInventoryItem("VSD's", "Siemens");
    var type = this.buildInventoryType("24VDC", "45354678-dfgdfg", 80);
    inventoryItem.Types.push(type);
    type = this.buildInventoryType("12VDC", "45648645465-asdghjhgas-45645", 80);
    inventoryItem.Types.push(type);
    type = this.buildInventoryType("230VAC", "1234-asjdkhas-556-1234564", 70);
    inventoryItem.Types.push(type);
    ItemData.push(inventoryItem);

    return ItemData;
  }

  private buildInventoryItem(name: string, make: string): InventoryItem {
    var inventoryItem = new InventoryItem();
    inventoryItem.ID = Guid.newGuid();
    inventoryItem.Name = "PLCs";
    inventoryItem.Make = "Siemens";
    inventoryItem.isExpanded = false;
    inventoryItem.Types = [];
    return inventoryItem;
  }

  private buildInventoryType(name: string, partNumber: string, qty: number): InventoryType {
    var inventoryType = new InventoryType();
    inventoryType.ID = Guid.newGuid();
    inventoryType.Name = "S71212 DC/DC/DC";
    inventoryType.PartNumber = "1258-456875-123145";
    inventoryType.Qty = 1;
    return inventoryType;
  }

  
}
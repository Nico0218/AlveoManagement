import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { InventoryItem } from '../models/inventory/inventory-item';
import { Guid } from '../classes/guid';


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
    var inventoryItem = this.buildInventoryItem("S71212 DC/DC/DC", "Siemens", "45665-5644-2852", 5);
    ItemData.push(inventoryItem);
    var inventoryItem = this.buildInventoryItem("S71214 DC/DC/DC", "Siemens", "45665-4852-2852", 5);
    ItemData.push(inventoryItem);
    var inventoryItem = this.buildInventoryItem("S71215 DC/DC/DC", "Siemens", "45665-1234-2852", 5);
    ItemData.push(inventoryItem);
    var inventoryItem = this.buildInventoryItem("S71217 DC/DC/DC", "Siemens", "45665-7845-2852", 5);
    ItemData.push(inventoryItem);
    var inventoryItem = this.buildInventoryItem("S71512 DC/DC/DC", "Siemens", "45665-1254-2852", 5);
    ItemData.push(inventoryItem);
    var inventoryItem = this.buildInventoryItem("S71515 DC/DC/DC", "Siemens", "45665-1236-2852", 5);
    ItemData.push(inventoryItem);
    var inventoryItem = this.buildInventoryItem("S71517 DC/DC/DC", "Siemens", "45665-4582-2852", 5);
    ItemData.push(inventoryItem);

    // //HMI's
    // inventoryItem = this.buildInventoryItem("HMI's", "Siemens");
    // ItemData.push(inventoryItem);

    // //VSD's
    // inventoryItem = this.buildInventoryItem("VSD's", "Siemens");
    // ItemData.push(inventoryItem);

    // //Contactor's
    // inventoryItem = this.buildInventoryItem("VSD's", "Siemens");
    // ItemData.push(inventoryItem);

    return ItemData;
  }

  private buildInventoryItem(name: string, make: string, partnumber: string, qty: number): InventoryItem {
    var inventoryItem = new InventoryItem();
    inventoryItem.ID = Guid.newGuid();
    inventoryItem.Name = name;
    inventoryItem.Make = make;
    inventoryItem.PartNumber = partnumber;
    inventoryItem.Qty = qty;
    return inventoryItem;
  }

}
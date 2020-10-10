import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { Environment } from '../classes/environment';
import { InventoryItemType } from '../enums/inventory-item-type';
import { InventoryItems } from '../models/inventory/inventory-items';
import { Item } from '../models/inventory/item';

@Injectable()
export class InventoryService {
  constructor(private httpClient: HttpClient) {

  }

  public get controllerURL(): string {
    return `${Environment.apiUrl}/Inventory`;
  }

  public GetAllInventoryItems(): Observable<InventoryItems> {
    return this.httpClient.get(`${this.controllerURL}/GetAllInventoryItems`)
      .pipe(
        map((ii: InventoryItems) => {
          return ii;
        }),
      );
  }

  public GetInventoryItemsByCategory(inventoryItemType: InventoryItemType): Observable<Item[]> {
    return this.httpClient.get(`${this.controllerURL}/GetInventoryItemsByCategory/${inventoryItemType}`)
      .pipe(
        map((ii: Item[]) => {
          return ii;
        }),
      );
  }
}
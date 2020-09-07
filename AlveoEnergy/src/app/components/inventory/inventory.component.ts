import { Component } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import { MatInputModule, MatPaginatorModule, MatProgressSpinnerModule, 
  MatSortModule, MatTableModule } from '@angular/material';
import { map, take } from 'rxjs/operators';
import { InventoryItem } from '../../models/inventory/inventory-item';
import { InventoryService } from '../../services/inventory.service';

@Component({
  selector: 'inventory',
  styleUrls: ['./inventory.component.scss'],
  templateUrl: './inventory.component.html',
})
export class InventoryComponent {
  ITEM_DATA: InventoryItem[];

  constructor(private inventoryService: InventoryService) {

  }

  dataItemsList = new MatTableDataSource();
  displayedItemsColumnsList: string[] = ['id', 'partNumber', 'name', 'Make', 'Qty'];

  ngOnInit() {
    this.inventoryService.GetAllInventoryItems()//This function builds and returns a Observable
      .pipe( // pipe allows us to define actions or "effects" that should happen with the Observable - Note at this point the Observable has not "Run" yet
        map(inventoryItems => { // https://www.learnrxjs.io/learn-rxjs/operators/transformation/map
          this.ITEM_DATA = inventoryItems;
          this.dataItemsList.data = this.ITEM_DATA;
        }),
        take(1) // https://www.learnrxjs.io/learn-rxjs/operators/filtering/take
      )
      .subscribe();// Subscribe starts the execution of the Observable
  }
}

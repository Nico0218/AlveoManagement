import { state, style, trigger } from '@angular/animations';
import { Component } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import { map, take } from 'rxjs/operators';
import { InventoryItem } from '../../models/inventory/inventory-item';
import { InventoryService } from '../../services/inventory.service';

@Component({
  selector: 'inventory',
  templateUrl: './inventory.component.html',
  styleUrls: ['./inventory.component.scss'],
  animations: [
    trigger('detailExpand', [
      state('collapsed', style({ display: 'none', height: '0px', minHeight: '0' })),
      state('expanded', style({ height: '*' })),
      //transition('expanded <=> collapsed', animate('225ms cubic-bezier(0.4, 0.0, 0.2, 1)')),
    ]),
  ],
})
export class InventoryComponent {
  isTableExpanded = false;
  ITEM_DATA: InventoryItem[];

  constructor(private inventoryService: InventoryService) {

  }

  dataItemsList = new MatTableDataSource();
  displayedItemsColumnsList: string[] = ['id', 'name', 'Make', 'actions'];

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

  // Toggel Rows
  toggleTableRows() {
    this.isTableExpanded = !this.isTableExpanded;

    this.dataItemsList.data.forEach((row: any) => {
      row.isExpanded = this.isTableExpanded;
    })
  }

}
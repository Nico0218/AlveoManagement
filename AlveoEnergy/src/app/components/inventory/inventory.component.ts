import { Component } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import { map, take } from 'rxjs/operators';
import { PlcItem } from '../../models/inventory/plc-item';
import { InventoryService } from '../../services/inventory.service';
import { HmiItem } from '../../models/inventory/hmi-item';
import { VsdItem } from '../../models/inventory/vsd-item';

@Component({
  selector: 'inventory',
  styleUrls: ['./inventory.component.scss'],
  templateUrl: './inventory.component.html',
})
export class InventoryComponent {
  PLC_DATA: PlcItem[];
  HMI_DATA: HmiItem[];
  VSD_DATA: VsdItem[];

  constructor(private inventoryService: InventoryService) {

  }

  plcItemsList = new MatTableDataSource();
  displayedPlcColumnsList: string[] = ['id', 'partNumber', 'name', 'Make', 'Qty'];
  hmiItemsList = new MatTableDataSource();
  displayedHmiColumnsList: string[] = ['id', 'partNumber', 'name', 'Make', 'Qty'];
  vsdItemsList = new MatTableDataSource();
  displayedVsdColumnsList: string[] = ['id', 'partNumber', 'name', 'Make', 'Qty'];

  applyPlcFilter(event: Event) {
    const filterValue = (event.target as HTMLInputElement).value;
    this.plcItemsList.filter = filterValue.trim().toLowerCase();
  }

  applyHmiFilter(event: Event) {
    const filterValue = (event.target as HTMLInputElement).value;
    this.hmiItemsList.filter = filterValue.trim().toLowerCase();
  }

  applyVsdFilter(event: Event) {
    const filterValue = (event.target as HTMLInputElement).value;
    this.vsdItemsList.filter = filterValue.trim().toLowerCase();
  }

  ngOnInit() {
    this.inventoryService.GetAllPlcItems()//This function builds and returns a Observable
      .pipe( // pipe allows us to define actions or "effects" that should happen with the Observable - Note at this point the Observable has not "Run" yet
        map(plcItems => { // https://www.learnrxjs.io/learn-rxjs/operators/transformation/map
          this.PLC_DATA = plcItems;
          this.plcItemsList.data = this.PLC_DATA;
        }),
        take(1) // https://www.learnrxjs.io/learn-rxjs/operators/filtering/take
      )
      .subscribe();// Subscribe starts the execution of the Observable

      this.inventoryService.GetAllHmiItems()
      .pipe(
        map(hmiItems => {
          this.HMI_DATA = hmiItems;
          this.hmiItemsList.data = this.HMI_DATA;
        }),
        take(1)
      )
      .subscribe();

      this.inventoryService.GetAllVsdItems()
      .pipe(
        map(vsdItems => {
          this.VSD_DATA = vsdItems;
          this.vsdItemsList.data = this.VSD_DATA;
        }),
        take(1)
      )
      .subscribe();
  }
}

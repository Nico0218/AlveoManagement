import { Component } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import { map, take } from 'rxjs/operators';
import { PlcItem } from '../../models/inventory/plc-item';
import { InventoryService } from '../../services/inventory.service';
import { HmiItem } from '../../models/inventory/hmi-item';
import { VsdItem } from '../../models/inventory/vsd-item';
import { RelayItem } from '../../models/inventory/relay-item';

@Component({
  selector: 'inventory',
  styleUrls: ['./inventory.component.scss'],
  templateUrl: './inventory.component.html',
})
export class InventoryComponent {
  PLC_DATA: PlcItem[];
  HMI_DATA: HmiItem[];
  VSD_DATA: VsdItem[];
  RELAY_DATA: RelayItem[];

  constructor(private inventoryService: InventoryService) {

  }

  //creates data sources for plc, hmi and vsd items for list population
  plcItemsList = new MatTableDataSource();
  displayedPlcColumnsList: string[] = ['id', 'partNumber', 'name', 'Make', 'Qty'];
  hmiItemsList = new MatTableDataSource();
  displayedHmiColumnsList: string[] = ['id', 'partNumber', 'name', 'Make', 'Qty'];
  vsdItemsList = new MatTableDataSource();
  displayedVsdColumnsList: string[] = ['id', 'partNumber', 'name', 'Make', 'Qty'];
  relayItemsList = new MatTableDataSource();
  displayedRelayColumnsList: string[] = ['id', 'partNumber', 'name', 'Make', 'Qty'];

  //filters displayed plc results in form
  applyPlcFilter(event: Event) {
    const filterValue = (event.target as HTMLInputElement).value;
    this.plcItemsList.filter = filterValue.trim().toLowerCase();
  }

  //filters displayed hmi results in form
  applyHmiFilter(event: Event) {
    const filterValue = (event.target as HTMLInputElement).value;
    this.hmiItemsList.filter = filterValue.trim().toLowerCase();
  }

  //filters displayed vsd results in form
  applyVsdFilter(event: Event) {
    const filterValue = (event.target as HTMLInputElement).value;
    this.vsdItemsList.filter = filterValue.trim().toLowerCase();
  }

  applyRelayFilter(event: Event) {
    const filterValue = (event.target as HTMLInputElement).value;
    this.vsdItemsList.filter = filterValue.trim().toLowerCase();
  }

  getPLCRecord(row){
    console.log(row);
  }

  getHMIRecord(row){
    console.log(row);
  }

  getVSDRecord(row){
    console.log(row);
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

      this.inventoryService.GetAllRelayItems()
      .pipe(
        map(relayItems => {
          this.RELAY_DATA = relayItems;
          this.relayItemsList.data = this.RELAY_DATA;
        }),
        take(1)
      )
      .subscribe();
  }
}

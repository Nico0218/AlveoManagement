import { Component } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import { map, take } from 'rxjs/operators';
import { ModelItem } from '../../models/inventory/ModelItem';
import { InventoryService } from '../../services/inventory.service';

@Component({
  selector: 'inventory',
  styleUrls: ['./inventory.component.scss'],
  templateUrl: './inventory.component.html',
})
export class InventoryComponent {
  PLC_DATA: ModelItem[];
  HMI_DATA: ModelItem[];
  VSD_DATA: ModelItem[];
  RELAY_DATA: ModelItem[];
  CONTACTOR_DATA: ModelItem[];
  ISOLATOR_DATA: ModelItem[];

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
  contactorItemsList = new MatTableDataSource();
  displayedContactorColumnsList: string[] = ['id', 'partNumber', 'name', 'Make', 'Qty'];
  isolatorsList = new MatTableDataSource();
  displayedIsolatorColumnsList: string[] = ['id', 'partNumber', 'name', 'Make', 'Qty'];

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

  applyContactorFilter(event: Event) {
    const filterValue = (event.target as HTMLInputElement).value;
    this.contactorItemsList.filter = filterValue.trim().toLowerCase();
  }

  applyIsolatorFilter(event: Event) {
    const filterValue = (event.target as HTMLInputElement).value;
    this.isolatorsList.filter = filterValue.trim().toLowerCase();
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

      this.inventoryService.GetAllContactorItems()
      .pipe(
        map(contactorItems => {
          this.CONTACTOR_DATA = contactorItems;
          this.contactorItemsList.data = this.CONTACTOR_DATA;
        }),
        take(1)
      )
      .subscribe();

      this.inventoryService.GetAllIsolators()
      .pipe(
        map(isolators => {
          this.ISOLATOR_DATA = isolators;
          this.isolatorsList.data = this.ISOLATOR_DATA;
        }),
        take(1)
      )
      .subscribe();
  }
}

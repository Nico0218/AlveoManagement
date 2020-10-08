import { Component } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import { Console } from 'console';
import { map, take } from 'rxjs/operators';
import { ModelItem } from '../../models/inventory/ModelItem';
import { InventoryService } from '../../services/inventory.service';

@Component({
  selector: 'inventory',
  styleUrls: ['./inventory.component.scss'],
  templateUrl: './inventory.component.html',
})
export class InventoryComponent {
  AUTOMATION_DATA: ModelItem[];
  CABLETRAYS_DATA: ModelItem[];
  EXTRAS_DATA: ModelItem[];
  INSTRUMENTATION_DATA: ModelItem[];
  LABOUR_DATA: ModelItem[];
  OTHER_DATA: ModelItem[];
  MONITORING_DATA: ModelItem[];
  SWITCHGEAR_DATA: ModelItem[];


  constructor(private inventoryService: InventoryService) {

  }

  //creates data sources for plc, hmi and vsd items for list population
  automationList = new MatTableDataSource();
  displayedAutomationColumnsList: string[] = ['name', 'supplier', 'partnumber', 'instock', 'cost'];
  cabletraysList = new MatTableDataSource();
  displayedCabletraysColumnsList: string[] = ['name', 'supplier', 'partnumber', 'instock', 'cost'];
  extrasList = new MatTableDataSource();
  displayedExtrasColumnsList: string[] = ['name', 'supplier', 'partnumber', 'instock', 'cost'];
  instrumentationList = new MatTableDataSource();
  displayedInstrumentationColumnsList: string[] = ['name', 'supplier', 'partnumber', 'instock', 'cost'];
  labourList = new MatTableDataSource();
  displayedLabourColumnsList: string[] = ['name', 'supplier', 'partnumber', 'instock', 'cost'];
  otherList = new MatTableDataSource();
  displayedOtherColumnsList: string[] = ['name', 'supplier', 'partnumber', 'instock', 'cost'];
  monitoringList = new MatTableDataSource();
  displayedMonitoringColumnsList: string[] = ['name', 'supplier', 'partnumber', 'instock', 'cost'];
  switchgearList = new MatTableDataSource();
  displayedSwitchgearColumnsList: string[] = ['name', 'supplier', 'partnumber', 'instock', 'cost'];
  

  //filters displayed plc results in form
  applyAutomationFilter(event: Event) {
    const filterValue = (event.target as HTMLInputElement).value;
    this.automationList.filter = filterValue.trim().toLowerCase();
  }

  //filters displayed hmi results in form
  applyCabletraysFilter(event: Event) {
    const filterValue = (event.target as HTMLInputElement).value;
    this.cabletraysList.filter = filterValue.trim().toLowerCase();
  }

  //filters displayed vsd results in form
  applyExtrasFilter(event: Event) {
    const filterValue = (event.target as HTMLInputElement).value;
    this.extrasList.filter = filterValue.trim().toLowerCase();
  }

  applyInstrumentationFilter(event: Event) {
    const filterValue = (event.target as HTMLInputElement).value;
    this.instrumentationList.filter = filterValue.trim().toLowerCase();
  }

  applyLabourFilter(event: Event) {
    const filterValue = (event.target as HTMLInputElement).value;
    this.labourList.filter = filterValue.trim().toLowerCase();
  }

  applyOtherFilter(event: Event) {
    const filterValue = (event.target as HTMLInputElement).value;
    this.otherList.filter = filterValue.trim().toLowerCase();
  }

  applyMonitoringFilter(event: Event) {
    const filterValue = (event.target as HTMLInputElement).value;
    this.monitoringList.filter = filterValue.trim().toLowerCase();
  }

  applySwitchgearFilter(event: Event) {
    const filterValue = (event.target as HTMLInputElement).value;
    this.switchgearList.filter = filterValue.trim().toLowerCase();
  }



  ngOnInit() {
    this.inventoryService.GetAllAutomation()//This function builds and returns a Observable
      .pipe( // pipe allows us to define actions or "effects" that should happen with the Observable - Note at this point the Observable has not "Run" yet
        map(automation => { // https://www.learnrxjs.io/learn-rxjs/operators/transformation/map
          this.AUTOMATION_DATA = automation;
          this.automationList.data = this.AUTOMATION_DATA;
        }),
        take(1) // https://www.learnrxjs.io/learn-rxjs/operators/filtering/take
      )
      .subscribe();// Subscribe starts the execution of the Observable

      this.inventoryService.GetAllCabletrays()
      .pipe(
        map(cabletrays => {
          this.CABLETRAYS_DATA = cabletrays;
          this.cabletraysList.data = this.CABLETRAYS_DATA;
        }),
        take(1)
      )
      .subscribe();

      this.inventoryService.GetAllExtras()
      .pipe(
        map(extras => {
          this.EXTRAS_DATA = extras;
          this.extrasList.data = this.EXTRAS_DATA;
        }),
        take(1)
      )
      .subscribe();

      this.inventoryService.GetAllInstrumentation()
      .pipe(
        map(instrumentation => {
          this.INSTRUMENTATION_DATA = instrumentation;
          this.instrumentationList.data = this.INSTRUMENTATION_DATA;
        }),
        take(1)
      )
      .subscribe();

      this.inventoryService.GetAllLabour()
      .pipe(
        map(labour => {
          this.LABOUR_DATA = labour;
          this.labourList.data = this.LABOUR_DATA;
        }),
        take(1)
      )
      .subscribe();

      this.inventoryService.GetAllMonitoring()
      .pipe(
        map(monitoring => {
          this.MONITORING_DATA = monitoring;
          this.monitoringList.data = this.MONITORING_DATA;
        }),
        take(1)
      )
      .subscribe();

      this.inventoryService.GetAllOther()
      .pipe(
        map(other => {
          this.OTHER_DATA = other;
          this.otherList.data = this.OTHER_DATA;
        }),
        take(1)
      )
      .subscribe();

      this.inventoryService.GetAllSwitchgear()
      .pipe(
        map(switchgear => {
          this.SWITCHGEAR_DATA = switchgear;
          this.switchgearList.data = this.SWITCHGEAR_DATA;
        }),
        take(1)
      )
      .subscribe();
  }
}

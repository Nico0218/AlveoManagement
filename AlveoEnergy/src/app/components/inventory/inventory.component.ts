import { Component } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import { map, take } from 'rxjs/operators';
import { Item } from '../../models/inventory/item';
import { InventoryService } from '../../services/inventory.service';

@Component({
  selector: 'inventory',
  styleUrls: ['./inventory.component.scss'],
  templateUrl: './inventory.component.html',
})
export class InventoryComponent {
  AUTOMATION_DATA: Item[];
  CABLETRAYS_DATA: Item[];
  EXTRAS_DATA: Item[];
  INSTRUMENTATION_DATA: Item[];
  LABOUR_DATA: Item[];
  OTHER_DATA: Item[];
  MONITORING_DATA: Item[];
  SWITCHGEAR_DATA: Item[];


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
    this.inventoryService.GetAllInventoryItems()
      .pipe(
        map(inventoryItems => {
          this.AUTOMATION_DATA = inventoryItems.Automation;
          this.automationList.data = this.AUTOMATION_DATA;

          this.CABLETRAYS_DATA = inventoryItems.Cabletrays;
          this.cabletraysList.data = this.CABLETRAYS_DATA;

          this.EXTRAS_DATA = inventoryItems.Extras;
          this.extrasList.data = this.EXTRAS_DATA;

          this.INSTRUMENTATION_DATA = inventoryItems.Instrumentation;
          this.instrumentationList.data = this.INSTRUMENTATION_DATA;

          this.LABOUR_DATA = inventoryItems.Labour;
          this.labourList.data = this.LABOUR_DATA;

          this.MONITORING_DATA = inventoryItems.Monitoring;
          this.monitoringList.data = this.MONITORING_DATA;

          this.OTHER_DATA = inventoryItems.Other;
          this.otherList.data = this.OTHER_DATA;

          this.SWITCHGEAR_DATA = inventoryItems.Switchgear;
          this.switchgearList.data = this.SWITCHGEAR_DATA;
        }),
        take(1)
      )
      .subscribe();
  }
}

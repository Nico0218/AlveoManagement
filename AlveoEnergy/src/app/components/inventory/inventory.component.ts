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
  BRACKET_DATA: ModelItem[];
  DISTRIBUTION_DATA: ModelItem[];
  ETHERNET_DATA: ModelItem[];
  FANS_DATA: ModelItem[];
  FLOWMETERS_DATA: ModelItem[];
  FUSEHOLDERS_DATA: ModelItem[];
  MISC_DATA: ModelItem[];
  PLCAUX_DATA: ModelItem[];
  PSU_DATA: ModelItem[];
  PANEL_DATA: ModelItem[];
  PLUGS_DATA: ModelItem[];
  POWER_DATA: ModelItem[];
  SENSORS_DATA: ModelItem[];
  STARTERS_DATA: ModelItem[];
  SURGE_DATA: ModelItem[];
  SWITCH_DATA: ModelItem[];
  TRANSFORMER_DATA: ModelItem[];
  UPS_DATA: ModelItem[];
  VSDAUX_DATA: ModelItem[];

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
  bracketsList = new MatTableDataSource();
  displayedBracketColumnsList: string[] = ['id', 'partNumber', 'name', 'Make', 'Qty'];
  distributionList = new MatTableDataSource();
  displayedDistributionColumnsList: string[] = ['id', 'partNumber', 'name', 'Make', 'Qty'];
  ethernetList = new MatTableDataSource();
  displayedEthernetColumnsList: string[] = ['id', 'partNumber', 'name', 'Make', 'Qty'];
  fansList = new MatTableDataSource();
  displayedFansColumnsList: string[] = ['id', 'partNumber', 'name', 'Make', 'Qty'];
  flowmetersList = new MatTableDataSource();
  displayedFlowmetersColumnsList: string[] = ['id', 'partNumber', 'name', 'Make', 'Qty'];
  fuseholdersList = new MatTableDataSource();
  displayedFuseholdersColumnsList: string[] = ['id', 'partNumber', 'name', 'Make', 'Qty'];
  miscList = new MatTableDataSource();
  displayedMiscColumnsList: string[] = ['id', 'partNumber', 'name', 'Make', 'Qty'];
  plcauxList = new MatTableDataSource();
  displayedPlcauxColumnsList: string[] = ['id', 'partNumber', 'name', 'Make', 'Qty'];
  psuList = new MatTableDataSource();
  displayedPsuColumnsList: string[] = ['id', 'partNumber', 'name', 'Make', 'Qty'];
  panelList = new MatTableDataSource();
  displayedPanelColumnsList: string[] = ['id', 'partNumber', 'name', 'Make', 'Qty'];
  plugsList = new MatTableDataSource();
  displayedPlugsColumnsList: string[] = ['id', 'partNumber', 'name', 'Make', 'Qty'];
  powerList = new MatTableDataSource();
  displayedPowerColumnsList: string[] = ['id', 'partNumber', 'name', 'Make', 'Qty'];
  sensorsList = new MatTableDataSource();
  displayedSensorsColumnsList: string[] = ['id', 'partNumber', 'name', 'Make', 'Qty'];
  startersList = new MatTableDataSource();
  displayedStartersColumnsList: string[] = ['id', 'partNumber', 'name', 'Make', 'Qty'];
  surgeList = new MatTableDataSource();
  displayedSurgeColumnsList: string[] = ['id', 'partNumber', 'name', 'Make', 'Qty'];
  switchList = new MatTableDataSource();
  displayedSwitchColumnsList: string[] = ['id', 'partNumber', 'name', 'Make', 'Qty'];
  transformerList = new MatTableDataSource();
  displayedTransformerColumnsList: string[] = ['id', 'partNumber', 'name', 'Make', 'Qty'];
  upsList = new MatTableDataSource();
  displayedUpsColumnsList: string[] = ['id', 'partNumber', 'name', 'Make', 'Qty'];
  vsdauxList = new MatTableDataSource();
  displayedVsdauxColumnsList: string[] = ['id', 'partNumber', 'name', 'Make', 'Qty'];

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

  applyBracketFilter(event: Event) {
    const filterValue = (event.target as HTMLInputElement).value;
    this.bracketsList.filter = filterValue.trim().toLowerCase();
  }

  applyDistributionFilter(event: Event) {
    const filterValue = (event.target as HTMLInputElement).value;
    this.distributionList.filter = filterValue.trim().toLowerCase();
  }

  applyEthernetFilter(event: Event) {
    const filterValue = (event.target as HTMLInputElement).value;
    this.ethernetList.filter = filterValue.trim().toLowerCase();
  }

  applyFansFilter(event: Event) {
    const filterValue = (event.target as HTMLInputElement).value;
    this.fansList.filter = filterValue.trim().toLowerCase();
  }

  applyFlowmetersFilter(event: Event) {
    const filterValue = (event.target as HTMLInputElement).value;
    this.flowmetersList.filter = filterValue.trim().toLowerCase();
  }

  applyFuseholdersFilter(event: Event) {
    const filterValue = (event.target as HTMLInputElement).value;
    this.fuseholdersList.filter = filterValue.trim().toLowerCase();
  }

  applyMiscFilter(event: Event) {
    const filterValue = (event.target as HTMLInputElement).value;
    this.miscList.filter = filterValue.trim().toLowerCase();
  }

  applyPlcauxFilter(event: Event) {
    const filterValue = (event.target as HTMLInputElement).value;
    this.plcauxList.filter = filterValue.trim().toLowerCase();
  }

  applyPsuFilter(event: Event) {
    const filterValue = (event.target as HTMLInputElement).value;
    this.psuList.filter = filterValue.trim().toLowerCase();
  }

  applyPanelFilter(event: Event) {
    const filterValue = (event.target as HTMLInputElement).value;
    this.panelList.filter = filterValue.trim().toLowerCase();
  }

  applyPlugsFilter(event: Event) {
    const filterValue = (event.target as HTMLInputElement).value;
    this.plugsList.filter = filterValue.trim().toLowerCase();
  }

  applyPowerFilter(event: Event) {
    const filterValue = (event.target as HTMLInputElement).value;
    this.powerList.filter = filterValue.trim().toLowerCase();
  }

  applySensorsFilter(event: Event) {
    const filterValue = (event.target as HTMLInputElement).value;
    this.sensorsList.filter = filterValue.trim().toLowerCase();
  }

  applyStartersFilter(event: Event) {
    const filterValue = (event.target as HTMLInputElement).value;
    this.startersList.filter = filterValue.trim().toLowerCase();
  }

  applySurgeFilter(event: Event) {
    const filterValue = (event.target as HTMLInputElement).value;
    this.startersList.filter = filterValue.trim().toLowerCase();
  }

  applySwitchFilter(event: Event) {
    const filterValue = (event.target as HTMLInputElement).value;
    this.switchList.filter = filterValue.trim().toLowerCase();
  }

  applyTransformerFilter(event: Event) {
    const filterValue = (event.target as HTMLInputElement).value;
    this.transformerList.filter = filterValue.trim().toLowerCase();
  }

  applyUpsFilter(event: Event) {
    const filterValue = (event.target as HTMLInputElement).value;
    this.upsList.filter = filterValue.trim().toLowerCase();
  }

  applyVsdauxFilter(event: Event) {
    const filterValue = (event.target as HTMLInputElement).value;
    this.vsdauxList.filter = filterValue.trim().toLowerCase();
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

      this.inventoryService.GetAllBrackets()
      .pipe(
        map(brackets => {
          this.BRACKET_DATA = brackets;
          this.bracketsList.data = this.BRACKET_DATA;
        }),
        take(1)
      )
      .subscribe();

      this.inventoryService.GetAllDistribution()
      .pipe(
        map(distribution => {
          this.DISTRIBUTION_DATA = distribution;
          this.distributionList.data = this.DISTRIBUTION_DATA;
        }),
        take(1)
      )
      .subscribe();

      this.inventoryService.GetAllEthernet()
      .pipe(
        map(ethernet => {
          this.ETHERNET_DATA = ethernet;
          this.ethernetList.data = this.ETHERNET_DATA;
        }),
        take(1)
      )
      .subscribe();

      this.inventoryService.GetAllFans()
      .pipe(
        map(fans => {
          this.FANS_DATA = fans;
          this.fansList.data = this.FANS_DATA;
        }),
        take(1)
      )
      .subscribe();

      this.inventoryService.GetAllFlowmeters()
      .pipe(
        map(flowmeters => {
          this.FLOWMETERS_DATA = flowmeters;
          this.flowmetersList.data = this.FLOWMETERS_DATA;
        }),
        take(1)
      )
      .subscribe();

      this.inventoryService.GetAllFuseholders()
      .pipe(
        map(fuseholders => {
          this.FUSEHOLDERS_DATA = fuseholders;
          this.fuseholdersList.data = this.FUSEHOLDERS_DATA;
        }),
        take(1)
      )
      .subscribe();

      this.inventoryService.GetAllMisc()
      .pipe(
        map(misc => {
          this.MISC_DATA = misc;
          this.miscList.data = this.MISC_DATA;
        }),
        take(1)
      )
      .subscribe();

      this.inventoryService.GetAllPlcaux()
      .pipe(
        map(plcaux => {
          this.PLCAUX_DATA = plcaux;
          this.plcauxList.data = this.PLCAUX_DATA;
        }),
        take(1)
      )
      .subscribe();

      this.inventoryService.GetAllPsu()
      .pipe(
        map(psu => {
          this.PSU_DATA = psu;
          this.psuList.data = this.PSU_DATA;
        }),
        take(1)
      )
      .subscribe();

      this.inventoryService.GetAllPanel()
      .pipe(
        map(panel => {
          this.PANEL_DATA = panel;
          this.panelList.data = this.PANEL_DATA;
        }),
        take(1)
      )
      .subscribe();

      this.inventoryService.GetAllPlugs()
      .pipe(
        map(plugs => {
          this.PLUGS_DATA = plugs;
          this.plugsList.data = this.PLUGS_DATA;
        }),
        take(1)
      )
      .subscribe();

      this.inventoryService.GetAllPower()
      .pipe(
        map(power => {
          this.POWER_DATA = power;
          this.powerList.data = this.POWER_DATA;
        }),
        take(1)
      )
      .subscribe();

      this.inventoryService.GetAllSensors()
      .pipe(
        map(sensors => {
          this.SENSORS_DATA = sensors;
          this.sensorsList.data = this.SENSORS_DATA;
        }),
        take(1)
      )
      .subscribe();

      this.inventoryService.GetAllStarters()
      .pipe(
        map(starters => {
          this.STARTERS_DATA = starters;
          this.startersList.data = this.STARTERS_DATA;
        }),
        take(1)
      )
      .subscribe();

      this.inventoryService.GetAllSurge()
      .pipe(
        map(surge => {
          this.SURGE_DATA = surge;
          this.surgeList.data = this.SURGE_DATA;
        }),
        take(1)
      )
      .subscribe();

      this.inventoryService.GetAllSwitch()
      .pipe(
        map(switches => {
          this.SWITCH_DATA = switches;
          this.switchList.data = this.SWITCH_DATA;
        }),
        take(1)
      )
      .subscribe();

      this.inventoryService.GetAllTransformer()
      .pipe(
        map(transformer => {
          this.TRANSFORMER_DATA = transformer;
          this.transformerList.data = this.TRANSFORMER_DATA;
        }),
        take(1)
      )
      .subscribe();

      this.inventoryService.GetAllUps()
      .pipe(
        map(ups => {
          this.UPS_DATA = ups;
          this.upsList.data = this.UPS_DATA;
        }),
        take(1)
      )
      .subscribe();

      this.inventoryService.GetAllVsdaux()
      .pipe(
        map(vsdaux => {
          this.VSDAUX_DATA = vsdaux;
          this.vsdauxList.data = this.VSDAUX_DATA;
        }),
        take(1)
      )
      .subscribe();

  }
}

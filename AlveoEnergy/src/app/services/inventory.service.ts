import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { PlcItem } from '../models/inventory/plc-item';
import { HmiItem } from '../models/inventory/hmi-item';
import { VsdItem } from '../models/inventory/vsd-item';
import { Guid } from '../classes/guid';


@Injectable()
export class InventoryService {
  public GetAllPlcItems(): Observable<PlcItem[]> {
    //https://www.learnrxjs.io/learn-rxjs/operators/creation/of
    return of(this.getPlcData()); // We wrap our data in an Observable here - Note at this point the Observable has not "Run" yet
  }

  public GetAllHmiItems(): Observable<HmiItem[]> {
    return of(this.getHmiData());
  }

  public GetAllVsdItems(): Observable<VsdItem[]> {
    return of(this.getVsdData());
  }

  //Temp method to fill data that will be retrieved from the backend API
  private getPlcData() {
    var PlcData: PlcItem[] = [];

    var plcItem = this.buildPlcItem("S71212 DC/DC/DC", "Siemens", "45665-5644-2852", 8);
    PlcData.push(plcItem);
    plcItem = this.buildPlcItem("S71214 DC/DC/DC", "Siemens", "45665-4852-2852", 4);
    PlcData.push(plcItem);
    plcItem = this.buildPlcItem("S71215 DC/DC/DC", "Siemens", "45665-1234-2852", 13);
    PlcData.push(plcItem);
    plcItem = this.buildPlcItem("S71217 DC/DC/DC", "Siemens", "45665-7845-2852", 8);
    PlcData.push(plcItem);
    plcItem = this.buildPlcItem("S71512 DC/DC/DC", "Siemens", "45665-1254-2852", 5);
    PlcData.push(plcItem);
    plcItem = this.buildPlcItem("S71515 DC/DC/DC", "Siemens", "45665-1236-2852", 1);
    PlcData.push(plcItem);
    plcItem = this.buildPlcItem("S71517 DC/DC/DC", "Siemens", "45665-4582-2852", 23);
    PlcData.push(plcItem);

    return PlcData;
  }

  private getHmiData() {
    var HmiData: HmiItem[] = [];

    var HmiItem = this.buildHmiItem("4' Basic", "Siemens", "485-895-asdqwe", 5);
    HmiData.push(HmiItem);
    HmiItem = this.buildHmiItem("7' Basic", "Siemens", "254-859-sdsdsfs", 3);
    HmiData.push(HmiItem);
    HmiItem = this.buildHmiItem("10' Basic", "Siemens", "485-358-asdqwe", 6);
    HmiData.push(HmiItem);
    HmiItem = this.buildHmiItem("12' Basic", "Siemens", "485-895-assdfwe", 2);
    HmiData.push(HmiItem);
    HmiItem = this.buildHmiItem("4' Basic", "Siemens", "485-8s5-asdqwe", 9);
    HmiData.push(HmiItem);
    HmiItem = this.buildHmiItem("4' Basic", "Siemens", "485-895-asdqwe", 5);
    HmiData.push(HmiItem);

    return HmiData;
    
  }

  private getVsdData() {
    var VsdData: VsdItem[] = [];

    var vsdItem = this.buildVsdItem("G120X 18 kW", "Siemens", "45665-5644-2852", 8);
    VsdData.push(vsdItem);
    vsdItem = this.buildVsdItem("G120X 7.5 KW", "Siemens", "45665-4852-2852", 4);
    VsdData.push(vsdItem);
    vsdItem = this.buildVsdItem("V20 2 KW", "Siemens", "45665-1234-2852", 13);
    VsdData.push(vsdItem);
    vsdItem = this.buildVsdItem("V20 5.5 KW", "Siemens", "45665-7845-2852", 8);
    VsdData.push(vsdItem);
    vsdItem = this.buildVsdItem("G120C Eth", "Siemens", "45665-1254-2852", 5);
    VsdData.push(vsdItem);
    vsdItem = this.buildVsdItem("G120C ProfiNet", "Siemens", "45665-1236-2852", 1);
    VsdData.push(vsdItem);
    vsdItem = this.buildVsdItem("G120C Modbus", "Siemens", "45665-4582-2852", 23);
    VsdData.push(vsdItem);

    return VsdData;
  }

  private buildPlcItem(name: string, make: string, partnumber: string, qty: number): PlcItem {
    var plcItem = new PlcItem();
    plcItem.ID = Guid.newGuid();
    plcItem.Name = name;
    plcItem.Make = make;
    plcItem.PartNumber = partnumber;
    plcItem.Qty = qty;
    return plcItem;
  }

  private buildHmiItem(name: string, make: string, partnumber: string, qty: number): HmiItem {
    var hmiItem = new HmiItem();
    hmiItem.ID = Guid.newGuid();
    hmiItem.Name = name;
    hmiItem.Make = make;
    hmiItem.PartNumber = partnumber;
    hmiItem.Qty = qty;
    return hmiItem;
  }

  private buildVsdItem(name: string, make: string, partnumber: string, qty: number): VsdItem {
    var vsdItem = new VsdItem();
    vsdItem.ID = Guid.newGuid();
    vsdItem.Name = name;
    vsdItem.Make = make;
    vsdItem.PartNumber = partnumber;
    vsdItem.Qty = qty;
    return vsdItem;
  }

}
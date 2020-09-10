import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { Guid } from '../classes/guid';
import { HmiItem } from '../models/inventory/hmi-item';
import { PlcItem } from '../models/inventory/plc-item';
import { VsdItem } from '../models/inventory/vsd-item';
import { map, catchError } from 'rxjs/operators';
import { Environment } from '../classes/environment';

@Injectable()
export class InventoryService {
  constructor(private httpClient: HttpClient) {

  }

  public get controllerURL(): string {
    return `${Environment.apiUrl}/Inventory`;
  }

  public GetAllPlcItems(): Observable<PlcItem[]> {
    return this.httpClient.get(`${this.controllerURL}/GetAllPLCItems`)
      .pipe(
        map((ii: PlcItem[]) => {
          return ii;
        }),
        catchError(ii => {
          //Return the default dummy data if we can`t get the data from the server
          return of(this.getPlcData());
        })
      );
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
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { Guid } from '../classes/guid';
import { ModelItem } from '../models/inventory/modelItem';
import { map, catchError } from 'rxjs/operators';
import { Environment } from '../classes/environment';
import { Inventory } from '../models/inventory/inventory';

@Injectable()
export class InventoryService {
  constructor(private httpClient: HttpClient) {

  }

  public get controllerURL(): string {
    return `${Environment.apiUrl}/Inventory`;
  }

  public GetAllPlcItems(): Observable<ModelItem[]> {
    return this.httpClient.get(`${this.controllerURL}/GetAllPLCItems`)
      .pipe(
        map((ii: ModelItem[]) => {
          return ii;
        }),
        catchError(ii => {
          //Return Error //Could not retrieve Data//
          return of(this.getPlcError());
        })
      );
  }

  public GetAllHmiItems(): Observable<ModelItem[]> {
    return this.httpClient.get(`${this.controllerURL}/GetAllHMIItems`)
      .pipe(
        map((ii: ModelItem[]) => {
          return ii;
        }),
        catchError(ii => {
          return of(this.getHmiError());
        })
      );
  }

  public GetAllVsdItems(): Observable<ModelItem[]> {
    return this.httpClient.get(`${this.controllerURL}/GetAllVSDItems`)
      .pipe(
        map((ii: ModelItem[]) => {
          return ii;
        }),
        catchError(ii => {
          return of(this.getVsdError());
        })
      );
  }

  public GetAllRelayItems(): Observable<ModelItem[]> {
    return this.httpClient.get(`${this.controllerURL}/GetAllRelayItems`)
      .pipe(
        map((ii: ModelItem[]) => {
          return ii;
        }),
        catchError(ii => {
          return of(this.getRelayError());
        })
      );
  }

  public GetAllContactorItems(): Observable<ModelItem[]> {
    return this.httpClient.get(`${this.controllerURL}/GetAllContactors`)
      .pipe(
        map((ii: ModelItem[]) => {
          return ii;
        }),
      );
  }

  public GetAllIsolators(): Observable<ModelItem[]> {
    return this.httpClient.get(`${this.controllerURL}/GetAllIsolators`)
      .pipe(
        map((ii: ModelItem[]) => {
          return ii;
        }),
      );
  }

  public GetAllInventoryItems(): Observable<Inventory[]> {
    return this.httpClient.get(`${this.controllerURL}/GetAllInventoryItems`)
      .pipe(
        map((ii: Inventory[]) => {
          return ii;
        }),
      );
  }

  // Method to report communication issue
  private getPlcError() {
    var PlcData: ModelItem[] = [];
    var plcItem = this.buildPlcError("Could not retrieve PLC Data", "Check Connection", "Error :");
    PlcData.push(plcItem);


    return PlcData;
  }

  private getHmiError() {
    var HmiData: ModelItem[] = [];
    var HmiItem = this.buildHmiError("Could not retrieve Hmi Data", "Check Connection", "Error");
    HmiData.push(HmiItem);
    return HmiData;

  }

  private getVsdError() {
    var VsdData: ModelItem[] = [];
    var vsdItem = this.buildVsdItem("Could not retrieve VSD Data", "Check Connection", "Error");
    VsdData.push(vsdItem);
    return VsdData;
  }

  private getRelayError() {
    var RelayData: ModelItem[] = [];
    var relayItem = this.buildRelayItem("Could not retrieve Relay Data", "Check Connection", "Error");
    RelayData.push(relayItem);
    return RelayData;
  }

  private buildPlcError(name: string, make: string, partnumber: string): ModelItem {
    var plcItem = new ModelItem();
    plcItem.ID = Guid.newGuid();
    plcItem.Name = name;
    plcItem.Make = make;
    plcItem.PartNumber = partnumber;
    return plcItem;
  }

  private buildHmiError(name: string, make: string, partnumber: string): ModelItem {
    var hmiItem = new ModelItem();
    hmiItem.ID = Guid.newGuid();
    hmiItem.Name = name;
    hmiItem.Make = make;
    hmiItem.PartNumber = partnumber;
    return hmiItem;
  }

  private buildVsdItem(name: string, make: string, partnumber: string): ModelItem {
    var vsdItem = new ModelItem();
    vsdItem.ID = Guid.newGuid();
    vsdItem.Name = name;
    vsdItem.Make = make;
    vsdItem.PartNumber = partnumber;
    return vsdItem;
  }

  private buildRelayItem(name: string, make: string, partnumber: string): ModelItem {
    var relayItem = new ModelItem();
    relayItem.ID = Guid.newGuid();
    relayItem.Name = name;
    relayItem.Make = make;
    relayItem.PartNumber = partnumber;
    return relayItem;
  }

}
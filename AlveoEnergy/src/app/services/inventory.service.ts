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

  public GetAllAutomation(): Observable<ModelItem[]> {
    return this.httpClient.get(`${this.controllerURL}/GetAllAutomation`)
      .pipe(
        map((ii: ModelItem[]) => {
          return ii;
        }),
      );
  }

  public GetAllCabletrays(): Observable<ModelItem[]> {
    return this.httpClient.get(`${this.controllerURL}/GetAllCabletrays`)
      .pipe(
        map((ii: ModelItem[]) => {
          return ii;
        }),
      );
  }

  public GetAllExtras(): Observable<ModelItem[]> {
    return this.httpClient.get(`${this.controllerURL}/GetAllExtras`)
      .pipe(
        map((ii: ModelItem[]) => {
          return ii;
        }),
      );
  }

  public GetAllInstrumentation(): Observable<ModelItem[]> {
    return this.httpClient.get(`${this.controllerURL}/GetAllInstrumentation`)
      .pipe(
        map((ii: ModelItem[]) => {
          return ii;
        }),
      );
  }

  public GetAllLabour(): Observable<ModelItem[]> {
    return this.httpClient.get(`${this.controllerURL}/GetAllLabour`)
      .pipe(
        map((ii: ModelItem[]) => {
          return ii;
        }),
      );
  }

  public GetAllOther(): Observable<ModelItem[]> {
    return this.httpClient.get(`${this.controllerURL}/GetAllOther`)
      .pipe(
        map((ii: ModelItem[]) => {
          return ii;
        }),
      );
  }

  public GetAllMonitoring(): Observable<ModelItem[]> {
    return this.httpClient.get(`${this.controllerURL}/GetAllMonitoring`)
      .pipe(
        map((ii: ModelItem[]) => {
          return ii;
        }),
      );
  }

  public GetAllSwitchgear(): Observable<ModelItem[]> {
    return this.httpClient.get(`${this.controllerURL}/GetAllSwitchgear`)
      .pipe(
        map((ii: ModelItem[]) => {
          return ii;
        }),
      );
  }

  public GetAllInventoryItems(): Observable<ModelItem[]> {
    return this.httpClient.get(`${this.controllerURL}/GetAllInventoryItems`)
      .pipe(
        map((ii: ModelItem[]) => {
          return ii;
        }),
      );
  }
}
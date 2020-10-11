import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { Customer } from '../models/customers/customers';
import { map, catchError } from 'rxjs/operators';
import { Environment } from '../classes/environment';
import { Item } from "../models/inventory/item";


@Injectable()
export class ScannerService {
    constructor(private httpClient: HttpClient) {

    }

    public get controllerURL(): string {
        return `${Environment.apiUrl}/scanner`;
      }

      RemoveItemFromInventory(item:Item): Observable<any> {
        return this.httpClient.post(`${this.controllerURL}/RemoveItemFromInventory`, item)
      }
}
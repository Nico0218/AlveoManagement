import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { Customer } from '../models/customers/customers';
import { map, catchError } from 'rxjs/operators';
import { Environment } from '../classes/environment';

@Injectable()
export class CustomerService {
    constructor(private httpClient: HttpClient) {

    }

    public get controllerURL(): string {
        return `${Environment.apiUrl}/Customer`;
      }

      public GetAllCustomerData(): Observable<Customer[]> {
        return this.httpClient.get(`${this.controllerURL}/GetAllCustomerData`)
          .pipe(
            map((ii: Customer[]) => {
              return ii;
            }),
          );
      }
}
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { Customer } from '../models/customers/customers';
import { map, catchError } from 'rxjs/operators';
import { Environment } from '../classes/environment';
import { Quote } from '../models/quote/quote';

@Injectable()
export class QuoteService {
    constructor(private httpClient: HttpClient) {

    }

    public get controllerURL(): string {
        return `${Environment.apiUrl}/quote`;
      }

      public GetAllQuotes(): Observable<Quote[]> {
        return this.httpClient.get(`${this.controllerURL}/GetAllQuotes`)
          .pipe(
            map((ii: Quote[]) => {
              return ii;
            }),
          );
      }
}
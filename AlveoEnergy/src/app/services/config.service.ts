import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { of } from 'rxjs';
import { map } from 'rxjs/operators';
import { Environment } from '../classes/environment';
import { AppSettings } from '../models/app-settings';

@Injectable()
export class ConfigService {
    constructor(private httpClient: HttpClient) {
    }

    public get controllerURL(): string {
        return `${Environment.apiUrl}/Config`;
    }

    public loadAppsettings(): Promise<any> {
        return this.httpClient.get("../../assets/appsettings.json").pipe(
            map((result: AppSettings) => {
                Environment.apiUrl = result.apiUrl;
                Environment.production = result.production;
                console.log(result);
                return of(result)
            })).toPromise();
    }

    // public IsConfigured(): Observable<boolean> {
    //     return this.httpClient.get(`${this.controllerURL}/IsConfigured`)
    //         .pipe(
    //             map((ii: boolean) => {
    //                 return ii;
    //             })
    //         );
    // }
}
import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { GanttObjWrapper } from '../models/gantt/gantt-data';
import { Tasks } from '../models/task';
import { Link } from '../models/link';
import { map, catchError } from 'rxjs/operators';
import { Environment } from '../classes/environment';
import { HttpClient } from '@angular/common/http';

@Injectable()
export class GanttService {
    constructor(private httpClient: HttpClient) {

    }
  
    public get controllerURL(): string {
      return `${Environment.apiUrl}/GanttData`;
    }

    public GetAllGanttData(): Observable<Tasks[]> {
      return this.httpClient.get(`${this.controllerURL}/GetAllGanttData`)
        .pipe(
          map((ii: Tasks[]) => {
            return ii;
          }),
        );
    }

    public GetAllGanttLinks(): Observable<Link[]> {
      return this.httpClient.get(`${this.controllerURL}/GetAllGanttLinks`)
        .pipe(
          map((ii: Link[]) => {
            return ii;
          }),
        );
    }

    public GetGanttDataWrapper(): Observable<GanttObjWrapper> {
      return this.httpClient.get(`${this.controllerURL}/GetGanttDataWrapper`)
        .pipe(
          map((ii: GanttObjWrapper) => {
            return ii;
          }),
        );
    }

    public GetGanttDataPersonnel(): Observable<GanttObjWrapper> {
      return this.httpClient.get(`${this.controllerURL}/GetGanttDataPersonnel`)
        .pipe(
          map((ii: GanttObjWrapper) => {
            return ii;
          }),
        );
    }


}
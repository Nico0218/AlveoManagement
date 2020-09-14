import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { GanttObjWrapper } from '../models/gantt/gantt-data';
import { Task } from '../models/task';
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

    public GetAllGanttData(): Observable<Task[]> {
      return this.httpClient.get(`${this.controllerURL}/GetAllGanttData`)
        .pipe(
          map((ii: Task[]) => {
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

    
  // public GetAllGanttData(): Observable<GanttData>{
  //   return of(this.getData());
  // }

  //   getData(): GanttData {
  //       var ganttData = new GanttData();
  //       ganttData.data = [
  //           {
  //               id: 1,
  //               text: "Zoar",
  //               start_date: "2020-09-04",
  //               duration: 2,
  //               color: "red",
  //               end_date: "2020-09-06",
  //               progress: 0,
  //               parent: 0
  //           },
  //           {
  //               id: 2,
  //               text: "Finish Container Work",
  //               start_date: "2020-09-04",
  //               duration: 1,
  //               color: "red",
  //               parent: 1,
  //               end_date: "2020-09-05",
  //               progress: 0
  //           },
  //           {
  //               id: 3,
  //               text: "Pack Items For Zoar",
  //               start_date: "2020-09-05",
  //               duration: 1,
  //               color: "red",
  //               parent: 1,
  //               end_date: "2020-09-06",
  //               progress: 0
  //           }
  //       ];
  //       ganttData.links = [
  //           { id: 1, source: 1, target: 2, type: "1" },                       //link's id = 1 
  //           { id: 2, source: 2, target: 3, type: "0" }                       //link's id = 2 
  //       ];
  //       return ganttData;
  //   }
}
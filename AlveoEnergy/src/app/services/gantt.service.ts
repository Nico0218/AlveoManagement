import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { GanttData } from '../models/gantt/gantt-task';

@Injectable()
export class GanttService {
    public GetAllGanttData(): Observable<GanttData> {
        //https://www.learnrxjs.io/learn-rxjs/operators/creation/of
        return of(this.getData()); // We wrap our data in an Observable here - Note at this point the Observable has not "Run" yet
    }

    getData(): GanttData {
        var ganttData = new GanttData();
        ganttData.data = [
            {
                id: 1,
                text: "Project #1",
                start_date: "2020-09-04",
                duration: 2,
                color: "red",
                end_date: "2020-09-06",
                progress: 0,
                parent: 0
            },
            {
                id: 2,
                text: "Task #1",
                start_date: "2020-09-04",
                duration: 1,
                color: "blue",
                parent: 1,
                end_date: "2020-09-05",
                progress: 0
            },
            {
                id: 3,
                text: "Task #2",
                start_date: "2020-09-05",
                duration: 1,
                color: "blue",
                parent: 1,
                end_date: "2020-09-06",
                progress: 0
            }
        ];
        ganttData.links = [
            { id: 1, source: 1, target: 2, type: "1" },                       //link's id = 1 
            { id: 2, source: 2, target: 3, type: "0" }                       //link's id = 2 
        ];
        return ganttData;
    }
}
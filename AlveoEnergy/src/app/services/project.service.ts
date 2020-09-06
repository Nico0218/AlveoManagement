import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';

@Injectable()
export class ProjectService {
    public GetAllProjects(): Observable<any[]> {
        //https://www.learnrxjs.io/learn-rxjs/operators/creation/of
        return of(this.getData()); // We wrap our data in an Observable here - Note at this point the Observable has not "Run" yet
    }

    getData(): any[] {
        return [];
    }
}
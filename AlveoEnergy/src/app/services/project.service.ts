import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable, of } from 'rxjs';
import { Projects } from '../models/projects/project';
import { Tasks } from "../models/task";
import { Guid } from '../classes/guid';
import { map, catchError } from 'rxjs/operators';
import { Environment } from '../classes/environment';
import { dataProcessor } from 'gantt';

@Injectable()
export class ProjectService {
  constructor(private httpClient: HttpClient) {
    
  }

  public get controllerURL(): string {
    return `${Environment.apiUrl}/Project`;
  }

    public GetAllProjects(): Observable<any[]> {
      return this.httpClient.get(`${this.controllerURL}/GetAllProjects`)
        .pipe(
          map((ii: Projects[]) => {
            return ii;
          }),
          catchError(ii => {
            return of(this.getProjectError());
          })
        );
    }

    SaveProject(project:Projects): Observable<any> {
      return this.httpClient.post(`${this.controllerURL}/SaveProject`, project)
    }

    UpdateProject(project:Projects): Observable<any> {
      debugger;
      return this.httpClient.post(`${this.controllerURL}/UpdateProject`, project)
    }

    SaveTask(task:Tasks): Observable<any> {
      return this.httpClient.post(`${this.controllerURL}/SaveTask`, task)
    }

    private getProjectError() {
      var ProjectData: Projects[] = [];
      var project = this.buildProject("Cannot Retrieve Project Data", "Please Check Connection", "", "");
      ProjectData.push(project);
  
      return ProjectData;
    }


      private buildProject(name: string, startDate: string, endDate: string, leader: string): Projects {
        var project = new Projects();
        project.Name = name;
        project.StartDate = startDate;
        project.EndDate = endDate;
        project.Leader = leader;
        return project;
      }
}
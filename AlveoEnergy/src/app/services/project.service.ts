import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { Projects } from '../models/projects/project';
import { Guid } from '../classes/guid';

@Injectable()
export class ProjectService {
    public GetAllProjects(): Observable<any[]> {
        //https://www.learnrxjs.io/learn-rxjs/operators/creation/of
        return of(this.getProjectData()); // We wrap our data in an Observable here - Note at this point the Observable has not "Run" yet
    }

    private getProjectData() {
        var ProjectData: Projects[] = [];
        var project = this.buildProject("Zoar", new Date().toLocaleString().slice(0,8), new Date().toLocaleString().slice(0,8), "Tinus");
        ProjectData.push(project);
        project = this.buildProject("JIJI", new Date().toLocaleString().slice(0,8), new Date().toLocaleString().slice(0,8), "Tinus");
        ProjectData.push(project);
        project = this.buildProject("Ladismith", new Date().toLocaleString().slice(0,8), new Date().toLocaleString().slice(0,8), "D'Andre");
        ProjectData.push(project);
        project = this.buildProject("Padenga", new Date().toLocaleString().slice(0,8), new Date().toLocaleString().slice(0,8), "Morne");
        ProjectData.push(project);
        project = this.buildProject("SABI", new Date().toLocaleString().slice(0,8), new Date().toLocaleString().slice(0,8), "Kobus");
        ProjectData.push(project);
        project = this.buildProject("Bapchix", new Date().toLocaleString().slice(0,8), new Date().toLocaleString().slice(0,8), "Tinus");
        ProjectData.push(project);
        project = this.buildProject("Kenmare", new Date().toLocaleString().slice(0,8), new Date().toLocaleString().slice(0,8), "Tinus");
        ProjectData.push(project);
    
        return ProjectData;
      }

      private buildProject(name: string, startDate: string, endDate: string, leader: string): Projects {
        var project = new Projects();
        project.Number = Guid.newGuid();
        project.Name = name;
        project.StartDate = startDate;
        project.EndDate = endDate;
        project.Leader = leader;
        return project;
      }
}
import { Component } from '@angular/core';
import { ProjectService } from '../../services/project.service';
import { Projects } from '../../models/projects/project';
import { MatTableDataSource } from '@angular/material/table';
import { map, take } from 'rxjs/operators';
import { Guid } from 'src/app/classes/guid';
import { GanttService } from "../../services/gantt.service";


@Component({
	selector: 'projects',
	styleUrls: ['./projects.component.scss'],
	templateUrl: './projects.component.html',
})
export class ProjectsComponent {
	PROJECT_DATA: Projects[];


	constructor(private projectService: ProjectService) {

	}

	projectsList = new MatTableDataSource();
	displayedProjectsColumnsList: string[] = ['projectNumber', 'projectName', 'projectStartDate', 'projectEndDate', 'projectLeader'];
	  
	CreateProject(projectNumber: string, projectName: string, projectStart: string, projectEnd: string, projectLeader: string, projectColor: string){

		const diffDays = (date, otherDate) => Math.ceil(Math.abs(date - otherDate) / (1000 * 60 * 60 * 24));
		  
		var Project = new Projects;
		Project.ID = new Guid;
		Project.StartDate = projectStart;
		Project.EndDate = projectEnd;
		Project.Number = projectNumber;
		Project.Name = projectName;
		Project.Progress = 0.0;
		Project.Duration = diffDays(new Date(projectStart), new Date(projectEnd));
		Project.Parent = "";
		Project.Color = projectColor;
		Project.Type = "project";
		Project.Personnel = "N/A"; 
		Project.Leader = projectLeader;
		this.projectService.WriteProjectToDB(Project);
	}

	applyProjectFilter(event: Event) {
		const filterValue = (event.target as HTMLInputElement).value;
		this.projectsList.filter = filterValue.trim().toLowerCase();
	  }

	  getProjectRecord(row){
		  console.log(row);
	  }


    ngOnInit() {
		this.projectService.GetAllProjects()
      .pipe(
        map(hmiItems => {
          this.PROJECT_DATA = hmiItems;
          this.projectsList.data = this.PROJECT_DATA;
        }),
        take(1)
      )
      .subscribe();
	}
}

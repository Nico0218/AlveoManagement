import { Component } from '@angular/core';
import { ProjectService } from '../../services/project.service';
import { Projects } from '../../models/projects/project';
import { Tasks } from "../../models/task";
import { MatTableDataSource } from '@angular/material/table';
import { map, take } from 'rxjs/operators';
import { Guid } from 'src/app/classes/guid';
import { GanttService } from "../../services/gantt.service";
import { discardPeriodicTasks } from '@angular/core/testing';
import { stringify } from 'querystring';
import { title } from 'process';


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

		const diffDays = (date, otherDate) => ((otherDate - date) / (1000 * 60 * 60 * 24));
		var alert = document.getElementById("alertProject");

		if (projectNumber == "" || projectName == "" || projectStart == "" || projectEnd == "" || projectLeader == ""){
			alert.style.color = "red";
			alert.innerHTML = "Please ensure all fields are filled in and dates selected!";

		} else {
			var Project = new Projects();
			Project.ID = Guid.newGuid();
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
	
			if (Project.Duration > 0){
				this.projectService.SaveProject(Project).subscribe();	
				alert.style.color = "green";
				alert.innerHTML = "Project has been Created!";
			} else {
				alert.style.color = "red";
				alert.innerHTML = "End date can not be earlier than start date";
			}
		}


	}

	CreateTask(taskName: string, taskStart: string, taskEnd: string, responsiblePerson: string, taskProject: string){

		const diffDays = (date, otherDate) => ((otherDate - date) / (1000 * 60 * 60 * 24));
		var alert = document.getElementById("alertTask");

		if (taskName == "" || taskStart == "" || responsiblePerson == "" || taskProject == "") {
			alert.style.color = "red";
			alert.innerHTML = "Please ensure all fields are filled in and dates selected!";

		} else {
			var Task = new Tasks();
			Task.ID = Guid.newGuid();
			Task.StartDate = taskStart;
			Task.EndDate = taskEnd;
			Task.Number = "";
			Task.Name = taskName;
			Task.Progress = 0.0;
			Task.Duration = diffDays(new Date(taskStart), new Date(taskEnd));
			Task.Parent = taskProject;
			Task.Color = "";
			Task.Type = "task";
			Task.Personnel = responsiblePerson; 
			Task.Leader = "";
	
			if (Task.Duration > 0){
				this.projectService.SaveTask(Task).subscribe();
				alert.style.color = "green";
				alert.innerHTML = "Task Has Been Created!";
			} else {
				alert.style.color = "red";
				alert.innerHTML = "End date can not be earlier than start date!";
			}
		}



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
        map(projects => {
          this.PROJECT_DATA = projects;
          this.projectsList.data = this.PROJECT_DATA;
        }),
        take(1)
      )
      .subscribe();
	}
}

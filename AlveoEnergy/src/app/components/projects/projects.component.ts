import { Component } from '@angular/core';
import { ProjectService } from '../../services/project.service';
import { Projects } from '../../models/projects/project';
import { MatTableDataSource } from '@angular/material/table';
import { map, take } from 'rxjs/operators';

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

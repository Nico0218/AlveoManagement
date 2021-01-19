import { AfterViewInit, Component, ElementRef, OnInit, ViewChild, ViewEncapsulation } from '@angular/core';
import { Console } from 'console';
import 'dhtmlx-gantt';
import { first, map } from 'rxjs/operators';
import { Projects } from 'src/app/models/projects/project';
import { ProjectService } from 'src/app/services/project.service';
import { GanttService } from '../../services/gantt.service';

var gantt = require('dhtmlx-gantt');

@Component({
	encapsulation: ViewEncapsulation.None,
	selector: 'gantt',
	styleUrls: ['./gantt.component.scss'],
	providers: [GanttService],
	templateUrl: './gantt.component.html',
})
export class GanttComponent implements OnInit, AfterViewInit {
	TASK_DATA: any[];
	LINK_DATA: any[];

	//points to gantt chart container
	@ViewChild('gantt_here') ganttContainer: ElementRef;

	constructor(private ganttService: GanttService, private projectService: ProjectService) {

	}

	ngAfterViewInit(): void {
		//initializes gantt chart and parses fetched data from backend
		this.setGanttStyleConfig();
		gantt.gantt.init(this.ganttContainer.nativeElement);

		this.ganttService.GetGanttDataWrapper()
			.pipe(
				map(ganttObjWrapper => {
					gantt.gantt.clearAll();
					gantt.gantt.parse(ganttObjWrapper);
					gantt.gantt.showDate(new Date());
				})
			)
			.subscribe()

		gantt.gantt.refreshData();

	}

	ngOnInit() {
		gantt.gantt.attachEvent("onTaskSelected", function (id) {
			//gantt.gantt.getTaskByIndex(id - 1)
			const task = gantt.gantt.getTask(id);
			document.getElementById("taskNameDisplay").innerHTML = "Task Name : " + task.text;
			document.getElementById("taskStartDateDisplay").innerHTML = "Task Start Date : " + task.start_date;
			document.getElementById("taskEndDisplay").innerHTML = "Task End Date : " + task.end_date;
			document.getElementById("taskDurationDisplay").innerHTML = "Task Duration : " + task.duration + " day/s";
			// gantt.gantt.getTaskByIndex(id - 1).color = document.getElementById("taskColor").value;
			gantt.gantt.refreshData();
		});

		gantt.gantt.attachEvent("onAfterTaskUpdate", (id, item) => {
			var Project = this.convertGanttItemToProject(item);
			this.projectService.UpdateProject(Project).pipe(first()).subscribe();
		});

		gantt.gantt.attachEvent("onAfterTaskDelete", (id, item) => {
			var Project = this.convertGanttItemToProject(item);
			this.projectService.DeleteProject(Project).pipe(first()).subscribe();
		});
	}

	private convertGanttItemToProject(item: any): Projects {
		var Project = new Projects();
		Project.ID = item.id;
		Project.StartDate = this.CleanupDate(item.start_date);
		Project.EndDate = this.CleanupDate(item.end_date);
		Project.Number = item.ProjectNumber;
		Project.Name = item.text;
		Project.Progress = item.progress;
		Project.Duration = this.diffDays(new Date(item.start_date), new Date(item.end_date));
		Project.Parent = item.parent?.toString();
		Project.Color = item.color;
		Project.Type = item.gantttype;
		Project.Personnel = "N/A";
		Project.Leader = item.ProjectLeader;
		return Project;
	}

	private diffDays(startDate: any, endDate: any): number {
		return (endDate - startDate) / (1000 * 60 * 60 * 24);
	}

	//sets gantt styling and layout
	private setGanttStyleConfig() {
		gantt.gantt.config.xml_date = '%Y-%m-%d %H:%i';
		gantt.gantt.config.layout = {
			css: "gantt_container",
			rows: [
				{
					cols: [
						{
							// the default grid view  
							view: "grid",
							scrollX: "scrollHor",
							scrollY: "scrollVer"
						},
						{ resizer: true, width: 1 },
						{
							// the default timeline view
							view: "timeline",
							scrollX: "scrollHor",
							scrollY: "scrollVer"
						},
						{
							view: "scrollbar",
							id: "scrollVer"
						}
					]
				},
				{
					view: "scrollbar",
					id: "scrollHor"
				}
			]
		}
	}

	//Hacks to handle dumb javascript dates
	private CleanupDate(rawDate: Date): string {
		if (rawDate) {
			return rawDate.toLocaleString("en-za").substring(0, 10);
		}
		return rawDate.toLocaleString("en-za").substring(0, 10);
	}
}
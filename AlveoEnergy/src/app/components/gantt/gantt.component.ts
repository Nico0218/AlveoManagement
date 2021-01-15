import { AfterViewInit, Component, ElementRef, OnInit, ViewChild, ViewEncapsulation } from '@angular/core';
import { Console } from 'console';
import 'dhtmlx-gantt';
import { map } from 'rxjs/operators';
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
			document.getElementById("taskNameDisplay").innerHTML = "Task Name : " + gantt.gantt.getTaskByIndex(id - 1).text;
			document.getElementById("taskStartDateDisplay").innerHTML = "Task Start Date : " + gantt.gantt.getTaskByIndex(id - 1).start_date;
			document.getElementById("taskEndDisplay").innerHTML = "Task End Date : " + gantt.gantt.getTaskByIndex(id - 1).end_date;
			document.getElementById("taskDurationDisplay").innerHTML = "Task Duration : " + gantt.gantt.getTaskByIndex(id - 1).duration + " day/s";
			// gantt.gantt.getTaskByIndex(id - 1).color = document.getElementById("taskColor").value;
			gantt.gantt.refreshData();
		});

		gantt.gantt.attachEvent("onAfterTaskUpdate", function(id, item){
			const diffDays = (date, otherDate) => ((otherDate - date) / (1000 * 60 * 60 * 24));

			var Project = new Projects();
			Project.StartDate = item.start_date;
			Project.EndDate = item.end_date;
			Project.Number = item.ProjectNumber;
			Project.Name = item.text;
			Project.Progress = 0.0;
			Project.Duration = diffDays(new Date(item.start_date), new Date(item.end_date));
			Project.Parent = item.Parent;
			Project.Color = item.color;
			Project.Type = item.Type;
			Project.Personnel = "N/A"; 
			Project.Leader = item.ProjectLeader;

			this.projectService.UpdateProject(Project).subscribe();	
		});

		gantt.gantt.attachEvent("onAfterTaskDelete", function(id,item){
			console.log("Task Deleted");
		});
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
}
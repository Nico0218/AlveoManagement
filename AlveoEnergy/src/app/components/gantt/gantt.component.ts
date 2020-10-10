import { AfterViewInit, Component, ElementRef, OnInit, ViewChild, ViewEncapsulation } from '@angular/core';
import { SelectControlValueAccessor } from '@angular/forms';
import 'dhtmlx-gantt';
import { map } from 'rxjs/operators';
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

	constructor(private ganttService: GanttService) {

	}

	ngAfterViewInit(): void {
		//initializes gantt chart and parses fetched data from backend
		this.setGanttStyleConfig();
		gantt.gantt.init(this.ganttContainer.nativeElement);

		this.ganttService.GetGanttDataWrapper()
			.pipe(
				map(ganttObjWrapper => {
					console.log(ganttObjWrapper);
					gantt.gantt.parse(ganttObjWrapper);
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
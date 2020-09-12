import { Component, ElementRef, OnInit, ViewChild, ViewEncapsulation, AfterViewInit } from '@angular/core';
import { Task } from '../../models/task';
import { Link } from '../../models/link';
import 'dhtmlx-gantt';
import { GanttService } from '../../services/gantt.service';
import { map, mergeAll } from 'rxjs/operators';
import { GanttData } from 'src/app/models/gantt/gantt-task';
import { link } from 'fs';
import { merge } from 'rxjs';

var gantt = require('dhtmlx-gantt');

@Component({
	encapsulation: ViewEncapsulation.None,
	selector: 'gantt',
	styleUrls: ['./gantt.component.scss'],
	providers: [ GanttService ],
	templateUrl: './gantt.component.html',
})
export class GanttComponent implements OnInit, AfterViewInit {
	TASK_DATA : any[];
	LINK_DATA : any[];
	

	@ViewChild('gantt_here') ganttContainer: ElementRef;

	constructor(private ganttService: GanttService) {

	}
	ngAfterViewInit(): void {
		const myJson: GanttData[] = [];

		this.setGanttStyleConfig();
		gantt.gantt.init(this.ganttContainer.nativeElement);

		this.ganttService.GetAllGanttData()
		.pipe(
		  map(ganttData => {
			this.TASK_DATA = ganttData;
		  }),
		)
		.subscribe();

		this.ganttService.GetAllGanttLinks()
		.pipe(
		  map(ganttLink => {
			this.LINK_DATA = ganttLink;
		  }),
		)
		.subscribe();
		  console.log(myJson);

	// 			gantt.gantt.parse({ data, links });




		// this.ganttService.GetAllGanttData()
		// 	.pipe(
		// 		map(ganttData => {
		// 			gantt.gantt.parse(ganttData)
		// 			console.log(ganttData)
		// 		})
		// 	)
		// 	.subscribe();
	}

	ngOnInit() {
		
	}

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

	// public Save() {
	// 	var data = [];
	// 	gantt.gantt.eachTask(ii => {
	// 		data.push(ii);
	// 	});
	// 	console.log(JSON.stringify(data))
	// };
}
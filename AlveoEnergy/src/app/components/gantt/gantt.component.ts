import { Component, ElementRef, OnInit, ViewChild, ViewEncapsulation, AfterViewInit } from '@angular/core';
import { Task } from '../../models/task';
import { Link } from '../../models/link';
import 'dhtmlx-gantt';
import { GanttService } from '../../services/gantt.service';
import { map } from 'rxjs/operators';

var gantt = require('dhtmlx-gantt');

@Component({
	encapsulation: ViewEncapsulation.None,
	selector: 'gantt',
	styleUrls: ['./gantt.component.scss'],
	providers: [ GanttService ],
	templateUrl: './gantt.component.html',
})
export class GanttComponent implements OnInit, AfterViewInit {
	@ViewChild('gantt_here') ganttContainer: ElementRef;

	constructor(private ganttService: GanttService) {

	}
	ngAfterViewInit(): void {
		this.setGanttStyleConfig();
		gantt.gantt.init(this.ganttContainer.nativeElement);
		// const dp = gantt.gantt.createDataProcessor({
		// 	task: {
		// 		update: (data: Task) => this.taskService.update(data),
		// 		create: (data: Task) => {
		// 			this.taskService.insert(data);
		// 			gantt.gantt.resetLayout();
		// 		},
		// 		delete: (id) => this.taskService.remove(id)
		// 	},
		// 	link: {
		// 		update: (data: Link) => this.linkService.update(data),
		// 		create: (data: Link) => this.linkService.insert(data),
		// 		delete: (id) => this.linkService.remove(id)
		// 	}
		// });

		// Promise.all([this.taskService.get(), this.linkService.get()])
		// 	.then(([data, links]) => {
		// 		gantt.gantt.parse({ data, links });
		// 	});
debugger;
		this.ganttService.GetAllGanttData()
			.pipe(
				map(ganttData => {
					gantt.gantt.parse(ganttData)
				})
			)
			.subscribe();
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

	public Save() {
		var data = [];
		gantt.gantt.eachTask(ii => {
			data.push(ii);
		});
		console.log(JSON.stringify(data))
	};
}
import { Component, ElementRef, OnInit, ViewChild, ViewEncapsulation, AfterViewInit } from '@angular/core';
import { TaskService } from '../../services/task.service';
import { LinkService } from '../../services/link.service';
import { Task } from '../../models/task';
import { Link } from '../../models/link';
import 'dhtmlx-gantt';

var gantt = require('dhtmlx-gantt');
// if (gantt.gantt.selectedId() != null) {
// 	var TaskName = gantt.gantt.getTask(gantt.gantt.getSelectedId()).text;
// 	var TaskStartDate = gantt.gantt.getTask(gantt.gantt.getSelectedId()).Start_Date;
// }


@Component({
	encapsulation: ViewEncapsulation.None,
	selector: 'gantt',
	styleUrls: ['./gantt.component.scss'],
	providers: [TaskService, LinkService],
	templateUrl: './gantt.component.html',
})
export class GanttComponent implements OnInit, AfterViewInit {
	@ViewChild('gantt_here') ganttContainer: ElementRef;

	constructor(private taskService: TaskService, private linkService: LinkService) { }
	ngAfterViewInit(): void {

	}

	ngOnInit() {
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

		gantt.gantt.config.xml_date = '%Y-%m-%d %H:%i';

		var tasks = {
			data: [
				{
					id: 1,
					text: "Project #1",
					start_date: "2020-09-04",
					duration: 2,
					color: "red",
					end_date: "2020-09-06",
					progress: 0,
					parent: 0
				},
				{
					id: 2,
					text: "Task #1",
					start_date: "2020-09-04",
					duration: 1,
					color: "blue",
					parent: 1,
					end_date: "2020-09-05",
					progress: 0
				},
				{
					id: 3,
					text: "Task #2",
					start_date: "2020-09-05",
					duration: 1,
					color: "blue",
					parent: 1,
					end_date: "2020-09-06",
					progress: 0
				}
			],
			links:[
				{ id:1, source:1, target:2, type:"1"},                       //link's id = 1 
				{ id:2, source:2, target:3, type:"0"}                       //link's id = 2 
			]
		};

		gantt.gantt.init(this.ganttContainer.nativeElement);
		gantt.gantt.parse(tasks)

		const dp = gantt.gantt.createDataProcessor({
			task: {
				update: (data: Task) => this.taskService.update(data),
				create: (data: Task) => {
					this.taskService.insert(data);
					gantt.gantt.resetLayout();
				},
				delete: (id) => this.taskService.remove(id)
			},
			link: {
				update: (data: Link) => this.linkService.update(data),
				create: (data: Link) => this.linkService.insert(data),
				delete: (id) => this.linkService.remove(id)
			}
		});

		Promise.all([this.taskService.get(), this.linkService.get()])
			.then(([data, links]) => {
				gantt.gantt.parse({ data, links });
			});
	}

	public Save() {
		debugger
		var data = [];
		gantt.gantt.eachTask(ii => {
			data.push(ii);
		});
		console.log(JSON.stringify(data))
	};
}
import { Component, ElementRef, OnInit, ViewChild, ViewEncapsulation, AfterViewInit } from '@angular/core';
import { TaskService } from '../../services/task.service';
import { LinkService } from '../../services/link.service';
import { Task } from '../../models/task';
import { Link } from '../../models/link';
import 'dhtmlx-gantt';

var gantt = require('dhtmlx-gantt');

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

		gantt.gantt.config.xml_date = '%Y-%m-%d %H:%i';

		gantt.gantt.init(this.ganttContainer.nativeElement);

		const dp = gantt.gantt.createDataProcessor({
			task: {
				update: (data: Task) => this.taskService.update(data),
				create: (data: Task) => this.taskService.insert(data),
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
}
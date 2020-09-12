import { AfterViewInit, Component, ElementRef, OnInit, ViewChild, ViewEncapsulation } from '@angular/core';
import 'dhtmlx-gantt';
import { map } from 'rxjs/operators';
import { GanttService } from '../../services/gantt.service';


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

		this.setGanttStyleConfig();
		gantt.gantt.init(this.ganttContainer.nativeElement);

		this.ganttService.GetGanttDataWrapper()
			.pipe(
				map(ganttObjWrapper =>{
					console.log(ganttObjWrapper);
					gantt.gantt.parse(ganttObjWrapper);
				})
			)
			.subscribe()
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
}
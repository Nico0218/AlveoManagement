import { AfterViewInit, Component, ElementRef, OnInit, ViewChild, ViewEncapsulation } from '@angular/core';
import 'dhtmlx-gantt';
import { map } from 'rxjs/operators';
import { GanttService } from 'src/app/services/gantt.service';

var persGantt = require('dhtmlx-gantt');

@Component({
	encapsulation: ViewEncapsulation.None,
	selector: 'personnel.gantt',
	styleUrls: ['./personnel.gantt.component.scss'],
	providers: [GanttService],
	templateUrl: './personnel.gantt.component.html',
})
export class PersonnelGanttComponent implements OnInit, AfterViewInit {
	TASK_DATA: any[];
	PERSONNEL_DATA: any[];

	//points to gantt chart container
	@ViewChild('personnel_gantt') ganttContainer: ElementRef;

	constructor(private ganttService: GanttService) {

	}

	ngAfterViewInit(): void {
		//initializes gantt chart and parses fetched data from backend
		this.setGanttStyleConfig();
		persGantt.gantt.init(this.ganttContainer.nativeElement);

		this.ganttService.GetGanttDataPersonnel()
			.pipe(
				map(ganttObjPersonnel => {
					persGantt.gantt.clearAll();
					persGantt.gantt.parse(ganttObjPersonnel);
				})
			)
			.subscribe()
		persGantt.gantt.refreshData();
	}

	ngOnInit() {
	}

	//sets gantt styling and layout
	private setGanttStyleConfig() {
		persGantt.gantt.config.xml_date = '%Y-%m-%d %H:%i';
		persGantt.gantt.config.layout = {
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
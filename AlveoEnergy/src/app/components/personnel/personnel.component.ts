import { Component } from '@angular/core';
import { PersonnelService } from '../../services/personnel.service';
import { Personnel } from '../../models/personnel/personnel';
import { MatTableDataSource } from '@angular/material/table';
import { map, take } from 'rxjs/operators';

@Component({
	selector: 'personnel',
	styleUrls: ['./personnel.component.scss'],
	templateUrl: './personnel.component.html',
})
export class PersonnelComponent {
	PERSONNEL_DATA: Personnel[];


	constructor(private personnelService: PersonnelService) {

	}

	personnelList = new MatTableDataSource();
  	displayedPersonnelColumnsList: string[] = ['idnum', 'fullName', 'position', 'employementDate', 'contactNum'];

	applyPersonnelFilter(event: Event) {
		const filterValue = (event.target as HTMLInputElement).value;
		this.personnelList.filter = filterValue.trim().toLowerCase();
	  }

    ngOnInit() {
		this.personnelService.GetAllPersonnel()
      .pipe(
        map(hmiItems => {
          this.PERSONNEL_DATA = hmiItems;
          this.personnelList.data = this.PERSONNEL_DATA;
        }),
        take(1)
      )
      .subscribe();
	}
}
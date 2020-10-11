import { Component } from '@angular/core';
import { PersonnelService } from '../../services/personnel.service';
import { Personnel } from '../../models/personnel/personnel';
import { MatTableDataSource } from '@angular/material/table';
import { map, take } from 'rxjs/operators';
import { Guid } from 'src/app/classes/guid';

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

	  getPersonnelRecord(row){
		  console.log(row);
	  }

	  CreatePersonnel(firstName: string, lastName: string, startDate: string, contactNumber: string, jobDescription: string, taskColor: string){
		var alert = document.getElementById("alertPersonnel");
		debugger;
		if (firstName == undefined || lastName == undefined|| startDate == undefined || contactNumber == undefined || jobDescription == undefined) {
			alert.style.color = "red";
			alert.innerHTML = "Please ensure all fields have been filled in correctly!";

		} else {
			var personnel = new Personnel();
			personnel.ID = Guid.newGuid();
			personnel.Name = firstName;
			personnel.Surname = lastName;
			personnel.StartDate = startDate;
			personnel.ContactNumber = contactNumber;
			personnel.JobDescription = jobDescription;
			personnel.Color = taskColor;
			this.personnelService.SavePersonnel(personnel).subscribe();	
			alert.style.color = "green";
			alert.innerHTML = "Personnel has been Created!";
		}

	  }

    ngOnInit() {
		this.personnelService.GetAllPersonnel()
      .pipe(
        map(personnel => {
          this.PERSONNEL_DATA = personnel;
          this.personnelList.data = this.PERSONNEL_DATA;
        }),
        take(1)
      )
      .subscribe();
	}
}
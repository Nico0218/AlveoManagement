import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { Personnel } from '../models/personnel/personnel';
import { Guid } from '../classes/guid';

@Injectable()
export class PersonnelService {
    public GetAllPersonnel(): Observable<any[]> {
        //https://www.learnrxjs.io/learn-rxjs/operators/creation/of
        return of(this.getPersonnelData()); // We wrap our data in an Observable here - Note at this point the Observable has not "Run" yet
    }

    private getPersonnelData() {
        var PersonnelData: Personnel[] = [];
        var personnel = this.buildPersonnel("8812105132088", "Tinus Spangenberg", "Technician", "07/11/2019", "0828987503");
        PersonnelData.push(personnel);
        personnel = this.buildPersonnel("8958624583082", "Piet Voorbeeld", "Technician", "1/05/2016", "0826253589");
        PersonnelData.push(personnel);
        personnel = this.buildPersonnel("7526948783088", "Koos Verduidelik", "Technician", "31/12/2014", "0725681245");
        PersonnelData.push(personnel);
        personnel = this.buildPersonnel("9158625322083", "Jan Klug", "Technician", "15/02/2017", "0615263489");
        PersonnelData.push(personnel);
    
        return PersonnelData;
      }

      private buildPersonnel(idNumber: string, name: string, position: string, employementDate: string, contactNumber: string): Personnel {
        var personnel = new Personnel();
        personnel.IDNumber = idNumber;
        personnel.Name = name;
        personnel.Position = position;
        personnel.EmployementDate = employementDate;
        personnel.ContactNumber = contactNumber;
        return personnel;
      }
}
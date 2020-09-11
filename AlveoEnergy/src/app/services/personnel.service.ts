import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable, of } from 'rxjs';
import { Personnel } from '../models/personnel/personnel';
import { Guid } from '../classes/guid';
import { map, catchError } from 'rxjs/operators';
import { Environment } from '../classes/environment';

@Injectable()
export class PersonnelService {
  constructor(private httpClient: HttpClient) {
    
  }

  public get controllerURL(): string {
    return `${Environment.apiUrl}/Personnel`;
  }

    public GetAllPersonnel(): Observable<any[]> {
      return this.httpClient.get(`${this.controllerURL}/GetAllPersonnelDetails`)
        .pipe(
          map((ii: Personnel[]) => {
            return ii;
          }),
          catchError(ii => {
            return of(this.getPersonnelError());
          })
        );
    }

    private getPersonnelError() {
        var PersonnelData: Personnel[] = [];
        var personnel = this.buildPersonnel("Cannot Retrieve Personnel Data", "Please Check Connection", "", "", "");
        PersonnelData.push(personnel);
    
        return PersonnelData;
      }

      private buildPersonnel(idNumber: string, name: string, position: string, employementDate: string, contactNumber: string): Personnel {
        var personnel = new Personnel();
        personnel.IDNumber = idNumber;
        personnel.Name = name;
        personnel.Position = position;
        personnel.EmploymentDate = employementDate;
        personnel.ContactNumber = contactNumber;
        return personnel;
      }
}
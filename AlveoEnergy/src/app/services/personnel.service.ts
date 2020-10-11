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

    SavePersonnel(personnel:Personnel): Observable<any> {
      return this.httpClient.post(`${this.controllerURL}/SavePersonnel`, personnel);
    }

    private getPersonnelError() {
        var PersonnelData: Personnel[] = [];
        var personnel = this.buildPersonnel("Cannot Retrieve Personnel Data", "Please Check Connection", "", "", "");
        PersonnelData.push(personnel);
    
        return PersonnelData;
      }

      private buildPersonnel(name: string, surname: string, jobDescription: string, startDate: string, contactNumber: string): Personnel {
        var personnel = new Personnel();
        personnel.ID = new Guid();
        personnel.Name = name;
        personnel.Surname = surname;
        personnel.JobDescription = jobDescription;
        personnel.StartDate = startDate;
        personnel.ContactNumber = contactNumber;
        return personnel;
      }
}
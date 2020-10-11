
import { Guid } from '../../classes/guid';

export class Personnel {
    public ID: Guid;
    public Name: string;
    public Surname: string;
    public StartDate: string;
    public ContactNumber: string;
    public JobDescription: string;
    public Color: string;

    constructor() {

    }

    ToJson(): string {
        return JSON.stringify(this);
    }

    static FromJson(jObj: any): Personnel {
        var personnel = new Personnel();
        personnel.ID = jObj.ID;
        personnel.Name = jObj.Name;
        personnel.Surname = jObj.Surname;
        personnel.StartDate = jObj.StartDate;
        personnel.ContactNumber = jObj.ContactNumber;
        personnel.JobDescription = jObj.JobDescription;
        personnel.Color = jObj.Color;
        return personnel;
    }

}
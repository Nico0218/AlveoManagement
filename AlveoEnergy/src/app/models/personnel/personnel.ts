import { ModelBase } from '../model-base';
import { Guid } from '../../classes/guid';

export class Personnel extends ModelBase {
    public IDNumber: string;
    public Name: string;
    public Position: string;
    public EmploymentDate: string;
    public ContactNumber: string;

    constructor() {
        super();

    }

    ToJson(): string {
        return JSON.stringify(this);
    }

    static FromJson(jObj: any): Personnel {
        var personnel = new Personnel();
        personnel.IDNumber = jObj.ID;
        personnel.Name = jObj.Name;
        personnel.Position = jObj.Position;
        personnel.EmploymentDate = jObj.EmploymentDate;
        personnel.ContactNumber = jObj.ContactNumber;
        return personnel;
    }

}
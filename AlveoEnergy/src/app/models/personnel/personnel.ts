import { ModelBase } from '../model-base';
import { Guid } from '../../classes/guid';

export class Personnel extends ModelBase {
    public IDNumber: string;
    public Name: string;
    public Position: string;
    public EmployementDate: string;
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
        personnel.Position = jObj.PartNumber;
        personnel.EmployementDate = jObj.Qty;
        personnel.ContactNumber = jObj.Make;
        return personnel;
    }

}
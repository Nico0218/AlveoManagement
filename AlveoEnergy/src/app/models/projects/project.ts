import { ModelBase } from '../model-base';
import { Guid } from '../../classes/guid';

export class Projects extends ModelBase {
    public Number: Guid;
    public Name: string;
    public StartDate: string;
    public EndDate: string;
    public Leader: string;

    constructor() {
        super();

    }

    ToJson(): string {
        return JSON.stringify(this);
    }

    static FromJson(jObj: any): Projects {
        var project = new Projects();
        project.Number = jObj.ID;
        project.Name = jObj.Name;
        project.StartDate = jObj.PartNumber;
        project.EndDate = jObj.Qty;
        project.Leader = jObj.Make;
        return project;
    }

}
import { Guid } from 'src/app/classes/guid';


export class Projects {
    public ID: Guid;
    public StartDate: string;
    public EndDate: string;
    public Name: string;
    public Progress: number;
    public Duration: number;
    public Parent: string;
    public Color: string;
    public Type: String;
    public Personnel: string;
    public Leader: string;
    public Number: string;

    constructor() {
    }

    ToJson(): string {
        return JSON.stringify(this);
    }

    static FromJson(jObj: any): Projects {
        var project = new Projects();
        project.Number = jObj.ID;
        project.Name = jObj.Name;
        project.StartDate = jObj.StartDate;
        project.EndDate = jObj.EndDate;
        project.Leader = jObj.Leader;
        return project;
    }

}
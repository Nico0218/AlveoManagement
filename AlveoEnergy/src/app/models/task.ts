import { Guid } from 'src/app/classes/guid';


export class Tasks {
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

    static FromJson(jObj: any): Tasks {
        var project = new Tasks();
        project.ID = jObj.ID;
        project.StartDate = jObj.StartDate;
        project.EndDate = jObj.EndDate;
        project.Name = jObj.Name;
        project.Progress = jObj.Progress;
        project.Duration = jObj.Duration;
        project.Parent = jObj.Parent;
        project.Color = jObj.Color;
        project.Type = jObj.Type;
        project.Personnel = jObj.ProPersonnelgress;
        project.Leader = jObj.Leader;
        project.Number = jObj.Number;
        return project;
    }

}



export class Projects {
    public ID: string;
    public Number: string;
    public Name: string;
    public StartDate: string;
    public EndDate: string;
    public Leader: string;

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
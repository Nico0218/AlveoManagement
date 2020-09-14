import { Component, AfterViewInit } from '@angular/core';

@Component({
	selector: 'qr-code-gen',
	styleUrls: ['./qr-code-gen.component.scss'],
	templateUrl: './qr-code-gen.component.html',
})
export class QRCodeGenComponent{
    public qrdata: string = null;
    public level: "L" | "M" | "Q" | "H";
    public width: number;
    public partNumber: string;
    public qrValue: string;
    'qrSelector';
    
    ngAfterViewInit(): void {
        this.level = "M";
        debugger;
        this.qrdata = "Add Data"
        this.width = 256;
    }

    public GeneratePartQR(qrPartNumber: string, qrPartName: string, qrPartDescription: string){
        this.qrdata = "Part Number :" + qrPartNumber + "," + "Part Name :" + qrPartName + "," + "Part Description : " + qrPartDescription ;
        console.log(JSON.parse(this.qrdata));
    }

    public GeneratePersonnelQR(qrPersonName: string, qrPersonSurname:string, qrPersonContact:string){
        this.qrdata = "First Name " + qrPersonName + "," + " Last Name " + qrPersonSurname + "," + " Contact Number " + qrPersonContact ;
    }

    public GenerateProjectQR(qrProjectNumber: string, qrProjectName:string, qrProjectLead:string, qrProjectLocation:string, qrProjectStart:string, qrProjectDeadline:string){
        this.qrdata = "Project Number " + qrProjectNumber + "," + " Project Name " + qrProjectName + "," + " Leader " + qrProjectLead + "," + " Location " + qrProjectLocation + "," + "Start Date " + qrProjectStart + "," + " Deadline " + qrProjectDeadline;
    }
}
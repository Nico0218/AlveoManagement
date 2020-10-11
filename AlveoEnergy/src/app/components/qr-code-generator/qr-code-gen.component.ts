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

    public GeneratePartQR(qrPartNumber: string){
        this.qrdata = "Part Number :" + qrPartNumber;
    }

    public GeneratePersonnelQR(qrPersonName: string){
        this.qrdata = "First Name " + qrPersonName;
    }

    public GenerateProjectQR(qrProjectNumber: string){
        this.qrdata = "Project Number " + qrProjectNumber;
    }
}
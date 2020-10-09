import { AfterViewInit, Component, OnInit, ViewChild } from '@angular/core';
import { ZXingScannerComponent } from '@zxing/ngx-scanner';

@Component({
	selector: 'scanner',
	styleUrls: ['./scanner.component.scss'],
	templateUrl: './scanner.component.html',
})

export class ScannerComponent implements AfterViewInit{
  @ViewChild('scanner') scanner: ZXingScannerComponent;

  selectedDevice: any = null;
  qrResultString: string;
constructor(){

}

clearResult(): void {
  this.qrResultString = null;
}

ngAfterViewInit(): void {
  this.scanner.updateVideoInputDevices().then(
    devices =>{
      this.selectedDevice = devices[0];
      this.scanner.askForPermission().then(
        res =>{
          if(this.scanner.isCurrentDevice){
            this.scanner.restart()
            console.log("Ready");
          }
        }
      )
    }
  )
}

onCodeResult(resultString: string) {
  this.qrResultString = resultString;
  console.log(this.qrResultString);
  const scanDate = new Date();
  console.log(scanDate);
}

InventoryScanOut(resultString: string){
  //Check item scanned and remove quantity from DB and assign to project
}

InventoryScanIn(resultString: string){
  //disect string and write item to DB
}

ProjectStart(resultString: string){
  //check if project work has already started
  //create log for when work started on Project
}

ProjectLabour(resultString: string){
  //check whether Personnel is booked to another project and give notification of moving personnel to new project or assigning someone new
  //assign Labour to Project with start date //// Fetch Labour Cost From DB for Personnel
}

ProjectEnd(resultString: string){
  //create log for when work ended on Project and calculate total labour hours and item costs
}

}



import { Component, ViewChild, AfterViewInit } from '@angular/core';
import { ZXingScannerComponent } from '@zxing/ngx-scanner';

@Component({
  selector: 'scanner',
  styleUrls: ['./scanner.component.scss'],
  templateUrl: './scanner.component.html',
})

export class ScannerComponent implements AfterViewInit {
  @ViewChild('scanner') scanner: ZXingScannerComponent;

  selectedDevice: any = null;
  qrResultString: string;

  constructor() {
  }

  ngAfterViewInit(): void {
    this.scanner.updateVideoInputDevices().then(
      devices => {
        this.selectedDevice = devices[0];
        this.scanner.askForPermission().then(
          res => {
            if (res) {
              if (this.scanner.isCurrentDevice) {
                this.scanner.restart()
                console.log("ready");
              }
            }
          }
        );
      }
    );
  }

  clearResult(): void {
    this.qrResultString = null;
  }

  onCodeResult(resultString: any) {
    console.log(resultString);
  }

}

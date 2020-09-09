import { Component, OnInit } from '@angular/core';

@Component({
	selector: 'scanner',
	styleUrls: ['./scanner.component.scss'],
	templateUrl: './scanner.component.html',
})

export class ScannerComponent{
    qrResultString: string;

clearResult(): void {
  this.qrResultString = null;
}

onCodeResult(resultString: string) {
  this.qrResultString = resultString;
}

}



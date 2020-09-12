import { ViewChild } from '@angular/core';
import { Component, ElementRef, OnInit } from '@angular/core';
import { jsPDF } from 'jspdf';  
import html2canvas from 'html2canvas';

@Component({
	selector: 'invoice',
	styleUrls: ['./invoice.component.scss'],
	templateUrl: './invoice.component.html',
})
export class InvoiceComponent {
    public captureScreen()  
    {  
      var data = document.getElementById('contentToConvert');  
      html2canvas(data).then(canvas => {  
        // Few necessary setting options  
        var imgWidth = 210;   
        var pageHeight = 1000;    
        var imgHeight = canvas.height * imgWidth / canvas.width;  
        var heightLeft = imgHeight;  
    
        const contentDataURL = canvas.toDataURL('image/png')  
        let pdf = new jsPDF('p', 'mm', 'a4'); // A4 size page of PDF  
        var position = 0;  
        pdf.addImage(contentDataURL, 'PNG', 0, position, imgWidth, imgHeight)  
        pdf.save('MYPdf.pdf'); // Generated PDF   
      });  
    }  

    
  }  
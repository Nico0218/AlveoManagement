import { Component, OnInit } from '@angular/core';

@Component({
	selector: 'inventory',
	styleUrls: ['./inventory.component.scss'],
	templateUrl: './inventory.component.html',
})
export class InventoryComponent implements OnInit {


    getPartNumber(partSearch): void {

        document.getElementById('partNumDisp').innerText = partSearch;
        document.getElementById('partDescriptionDisp').innerText = 'Mock PLC';
        document.getElementById('partQtyDisp').innerText = '4';
        document.getElementById('partQtyOrderedDisp').innerText = '2';
        document.getElementById('partCostDisp').innerText = 'R7 958.32';
        document.getElementById('PartSupplierDisp').innerText = 'Siemens AG';
        }

    ngOnInit(): void {
    }
}
import { Component } from '@angular/core';
import { animate, state, style, transition, trigger } from '@angular/animations';
import { MatTableDataSource } from '@angular/material/table';


@Component({
  selector: 'inventory',
  templateUrl: './inventory.component.html',
  styleUrls: ['./inventory.component.scss'],
  animations: [
    trigger('detailExpand', [
      state('collapsed', style({ display: 'none',  height: '0px', minHeight: '0' })),
      state('expanded', style({ height: '*' })),
      //transition('expanded <=> collapsed', animate('225ms cubic-bezier(0.4, 0.0, 0.2, 1)')),
    ]),
  ],
})
export class InventoryComponent {

  isTableExpanded = false;

  ITEM_DATA = [
    {
      "id": 1,
      "name": "PLCs",
      "Make": "Siemens",
      "isExpanded": false,
      "subjects": [
        {
          "name": "S71212 DC/DC/DC",
          "PartNumber": "1258-456875-123145",
          "Qty": 5
        },
        {
          "name": "S71214C DC/DC/DC",
          "PartNumber": "1234654-4641-412314",
          "Qty": 3
        },
        {
          "name": "S71517",
          "PartNumber": "213654-23145612-123124",
          "Qty": 1
        }
      ]
    },
    {
      "id": 2,
      "name": "HMI's",
      "Make": "Siemens",
      "isExpanded": false,
      "subjects": [
        {
          "name": "12' Comfort",
          "PartNumber": "1235423-1234534123-453457748",
          "Qty": 10
        },
        {
          "name": "7' Basic",
          "PartNumber": "45612345-45682423-45645213",
          "Qty": 9
        },
        {
          "name": "15' Comfort",
          "PartNumber": "123486-45645313-456423",
          "Qty": 5
        }
      ]
    },
    {
      "id": 3,
      "name": "VSD's",
      "Make": "Siemens",
      "isExpanded": false,
      "subjects": [
        {
          "name": "G120x",
          "PartNumber": "45354678-41234561-24674",
          "Qty": 8
        },
        {
          "name": "V20",
          "PartNumber": "45648645465-456453213-45645",
          "Qty": 6
        },
        {
          "name": "G120c",
          "PartNumber": "1234556-1234564",
          "Qty": 7
        }
      ]
    },
    {
      "id": 4,
      "name": "Contactor's",
      "Make": "Siemens",
      "isExpanded": false,
      "subjects": [
        {
          "name": "24VDC",
          "PartNumber": "45354678-dfgdfg",
          "Qty": 80
        },
        {
          "name": "12VDC",
          "PartNumber": "45648645465-asdghjhgas-45645",
          "Qty": 60
        },
        {
          "name": "230VAC",
          "PartNumber": "1234-asjdkhas-556-1234564",
          "Qty": 70
        }
      ]
    }
  ];


  dataItemsList = new MatTableDataSource();
  displayedItemsColumnsList: string[] = ['id', 'name', 'Make', 'actions'];


  ngOnInit() {
    this.dataItemsList.data = this.ITEM_DATA;
  }

  // Toggel Rows
  toggleTableRows() {
    this.isTableExpanded = !this.isTableExpanded;

    this.dataItemsList.data.forEach((row: any) => {
      row.isExpanded = this.isTableExpanded;
    })
  }

}
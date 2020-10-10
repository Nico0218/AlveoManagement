import { Component, OnInit } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import html2canvas from 'html2canvas';
import * as jspdf from 'jspdf';
import { map, take } from 'rxjs/operators';
import { InventoryItems } from 'src/app/models/inventory/inventory-items';
import { CustomerService } from '../../services/customers.service';
import { InventoryService } from '../../services/inventory.service';
import { QuoteService } from '../../services/quote.service';

@Component({
	selector: 'quote',
	styleUrls: ['./quote.component.scss'],
	templateUrl: './quote.component.html',
})
export class QuoteComponent implements OnInit {
	QUOTE_DATA: any;

	constructor(private customerService: CustomerService, private inventoryService: InventoryService, private quoteService: QuoteService) {

	}

	quoteList = new MatTableDataSource();
	displayedQuoteColumnsList: string[] = ['quote', 'project', 'valid', 'attention', 'status'];

	public preparedBy = "";
	public preparedByEmail = "";
	public quoteDate = "";
	public quoteNumber = "";
	public customerID = "";
	public quoteValid = "";
	public orderNumber = "";
	public projectName = "";
	public attention = "";
	public preparedFor = "";
	public customerAddress1 = "";
	public customerAddress2 = "";
	public customerContactNumber = "";
	public customerEmail = "";
	public quoteSubTotal = 0.00;
	public quoteTaxRate = 0.00;
	public quoteTaxDue = 0.00;
	public quoteOther = 0.00;
	public quoteTotal = 0.00;
	public headers = ["Description", "Req", "Unit", "Rate", "Ammount"];
	public custOrderNum;
	public custProjectName;
	public custForAttention;
	public partReq = "";
	public customers = [];
	public items = [];
	public inventory: InventoryItems;
	public curUser;
	public curItem;
	public date;

	applyQuoteFilter(event: Event) {
		const filterValue = (event.target as HTMLInputElement).value;
		this.quoteList.filter = filterValue.trim().toLowerCase();
	}

	public convertToPDF() {
		window.scroll(0, 0);
		let pdf = new jspdf.jsPDF('p', 'mm', 'a4'); // A4 size page of PDF
		debugger;
		var data1 = document.getElementById('quote');
		var data2 = document.getElementById('terms')
		html2canvas(data1).then(canvas => {
			// Few necessary setting options
			const conten1tDataURL = canvas.toDataURL('image/png', 0.1)
			pdf.addImage(conten1tDataURL, 'JPG', 0, 0, 210, 297)
			pdf.addPage("JPG", "p")
			html2canvas(data2).then(canvas => {
				// Few necessary setting options
				const content2DataURL = canvas.toDataURL('image/png', 1.0)
				pdf.addImage(content2DataURL, 'JPG', 0, 0, 210, 297)
				pdf.save('new-file.pdf'); // Generated PDF
			});
		});
	}

	public ShowHide() {
		var x = document.getElementById("addItems");
		if (x.style.display === "none") {
			x.style.display = "block";
		} else {
			x.style.display = "none";
		}
	}

	public setNewUser(id: any) {
		console.log(id);
		// Match the selected ID with the ID's in array
		this.curUser = this.customers.filter(value => value.id === parseInt(id));
		console.log(this.curUser);
		this.preparedFor = this.curUser[0].name;
		this.customerAddress1 = this.curUser[0].addrLine1;
		this.customerAddress2 = this.curUser[0].addrLine2;
		this.customerEmail = this.curUser[0].email;
		this.customerContactNumber = this.curUser[0].contactNumber;
		this.customerID = this.curUser[0].customerID;
	}

	public pushItems(id: any) {
		// for (let index = 0; index < this.inventory.length; index++) {
		// 	if (this.inventory[index].ID == id) {
		// 		this.inventory[index].Req = Number(this.partReq);
		// 		this.inventory[index].Ammount = this.inventory[index].Rate * Number(this.partReq);
		// 		this.items.push(this.inventory[index]);
		// 		this.quoteSubTotal = this.quoteSubTotal + Number(this.inventory[index].Ammount);
		// 		this.quoteTaxRate = 15;
		// 		this.quoteTaxDue = this.quoteSubTotal * 0.15;
		// 		this.quoteTotal = this.quoteSubTotal + this.quoteTaxDue;
		// 	}
		// }
	}

	ngOnInit(): void {
		this.customerService.GetAllCustomerData()
			.pipe(
				map(customer => {
					this.customers = customer;
				}),
				take(1)
			)
			.subscribe();

		this.inventoryService.GetAllInventoryItems()
			.pipe(
				map(inventoryItems => {
					this.inventory = inventoryItems;
					console.log(this.inventory)
				}),
				take(1)
			)
			.subscribe();

		this.quoteService.GetAllQuotes()
			.pipe(
				map(quotes => {
					this.QUOTE_DATA = quotes;
					this.quoteList.data = this.QUOTE_DATA;
				}),
				take(1)
			)
			.subscribe();
	}

	public test() {
		this.preparedBy = "incorporate current logged in user";
		this.preparedByEmail = "incorporate current logged in user";
		this.date = new Date();
		this.quoteDate = this.date.toLocaleDateString();
		this.quoteNumber = "still needs data";
		this.quoteValid = new Date().toLocaleDateString();
		this.orderNumber = this.custOrderNum;
		this.projectName = this.custProjectName;
		this.attention = this.custForAttention;
	}
}
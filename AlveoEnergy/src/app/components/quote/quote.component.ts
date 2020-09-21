import { Component, OnInit } from '@angular/core';
import { Personnel } from '../../models/personnel/personnel';
import { Quote } from '../../models/quote/quote';
import { Customer } from '../../models/customers/customers';
import { FLOAT, float } from 'html2canvas/dist/types/css/property-descriptors/float';
import { CurrencyPipe } from '@angular/common';

@Component({
	selector: 'quote',
	styleUrls: ['./quote.component.scss'],
	templateUrl: './quote.component.html',
})
export class QuoteComponent implements OnInit {
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
	public headers = [];
	public items = [];



	public test(){
		var newCustomer = new Customer();
		newCustomer.name = "testCustomer",
		newCustomer.email = "customer@email.com",
		newCustomer.addrLine1 = "test Street 50",
		newCustomer.addrLine2 = "test suburb, test town, 7140",
		newCustomer.orderNumber = "test order Number",
		newCustomer.projectName = "test project",
		newCustomer.contact = "test name",
		newCustomer.name = "test Customer Name",
		newCustomer.contactNumber = "test ContactNumber"

		var newPersonnel = new Personnel();
		newPersonnel.Name = "tinus",
		newPersonnel.Email = "tinus.spangenberg@alveoenergy.co.za"

		var newQuote = new Quote();
		newQuote.date = new Date(),
		newQuote.quoteNumber = "Q20-025",
		newQuote.custId = "5",
		newQuote.validUntil = new Date(newQuote.date);

		this.preparedBy = newPersonnel.Name;
		this.preparedByEmail = newPersonnel.Email;
		this.orderNumber = newCustomer.orderNumber;
		this.projectName = newCustomer.projectName;
		this.attention = newCustomer.contact;
		this.preparedFor = newCustomer.name;
		this.customerAddress1 = newCustomer.addrLine1;
		this.customerAddress2 = newCustomer.addrLine2;
		this.customerContactNumber = newCustomer.contactNumber;
		this.customerEmail = newCustomer.email;
		this.quoteDate = newQuote.date.toLocaleDateString();
		this.quoteNumber = newQuote.quoteNumber;
		this.customerID = newQuote.custId;
		this.quoteValid = newQuote.validUntil.toLocaleDateString();

		this.headers = ["DESCRIPTION", "REQ", "UNIT", "RATE", "AMMOUNT"];
		this.items = [
			{
				"DESCRIPTION" : "Test Item",
				"REQ" : "1",
				"UNIT" : "10.00",
				"RATE" : "12.00",
				"AMMOUNT" : "20.00",
			},
			{
				"DESCRIPTION" : "Test Item 2",
				"REQ" : "5",
				"UNIT" : "10.00",
				"RATE" : "10.00",
				"AMMOUNT" : "50.00",
			},
			{
				"DESCRIPTION" : "Test Item 3",
				"REQ" : "6",
				"UNIT" : "20.00",
				"RATE" : "20.00",
				"AMMOUNT" : "120.00",
			},
			{
				"DESCRIPTION" : "Test Item 4",
				"REQ" : "10",
				"UNIT" : "20.00",
				"RATE" : "20.00",
				"AMMOUNT" : "200.00",
			}
		]

		// for (let index = 0; index < this.items.length; index++) {
		// 	var temp += Number(this.items[index].AMMOUNT);
			
		// }

		this.quoteSubTotal = Number(this.items[0].AMMOUNT) + Number(this.items[1].AMMOUNT) + Number(this.items[2].AMMOUNT) + Number(this.items[3].AMMOUNT);
		this.quoteTaxRate = 15;
		this.quoteTaxDue = this.quoteSubTotal*(this.quoteTaxRate/100);
		this.quoteTotal = this.quoteSubTotal + this.quoteTaxDue;
	}

	public AddItem(){

	}


    ngOnInit(): void {
	}
	

}
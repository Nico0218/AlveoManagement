import { Customer } from '../customers/customers';
import { Item } from '../inventory/item';
import { Personnel } from '../personnel/personnel';

export class Quote{
    Customer: Customer;
    OrderNumber: string;
    ProjectName: string;
    ForAttention: string;
    Date:  string;
    QuoteNumber: string;
    ValidUntil: string;
    QuoteItems: Item[];
    SubTotal: number;
    TaxRate: number;
    TaxDue: number;
    OtherCosts: number;
    QuoteTotal: number;
}
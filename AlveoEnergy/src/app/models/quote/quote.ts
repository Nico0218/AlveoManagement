import { Customer } from '../customers/customers';
import { Personnel } from '../personnel/personnel';

export class Quote{
    customer: Customer;
    orderNr: string;
    projectName: string;
    forAttention: string;
    date:  Date;
    quoteNumber: string;
    validUntil: Date;
    quoteItems: any;
    subTotal: number;
    taxRate: number;
    taxDue: number;
    otherCosts: number;
    quoteTotal: number;
}
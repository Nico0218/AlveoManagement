import { Customer } from '../customers/customers';
import { Personnel } from '../personnel/personnel';

export class Quote{
    date:  Date;
    quoteNumber: string;
    custId: string;
    validUntil: Date;
    quoteCustomer: Customer;
    preparedBy: Personnel;
}
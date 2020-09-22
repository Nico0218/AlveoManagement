import { ModelBase } from '../model-base';

export class HmiItem extends ModelBase {
    public Name: string;
    public Make: string;
    public PartNumber: string;
    public Qty: number;
    public Description: string;
    public Unit: string;
    public Rate: number;
    public Req: number;
    public Ammount: Number;

    constructor() {
        super();

    }

    ToJson(): string {
        return JSON.stringify(this);
    }

    static FromJson(jObj: any): HmiItem {
        var inventoryItem = new HmiItem();
        inventoryItem.ID = jObj.ID;
        inventoryItem.Name = jObj.Name;
        inventoryItem.PartNumber = jObj.PartNumber;
        inventoryItem.Qty = jObj.Qty;
        inventoryItem.Make = jObj.Make;
        return inventoryItem;
    }

}
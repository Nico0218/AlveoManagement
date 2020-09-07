import { ModelBase } from '../model-base';

export class PlcItem extends ModelBase {
    public Name: string;
    public Make: string;
    public PartNumber: string;
    public Qty: number;

    constructor() {
        super();

    }

    ToJson(): string {
        return JSON.stringify(this);
    }

    static FromJson(jObj: any): PlcItem {
        var inventoryItem = new PlcItem();
        inventoryItem.ID = jObj.ID;
        inventoryItem.Name = jObj.Name;
        inventoryItem.PartNumber = jObj.PartNumber;
        inventoryItem.Qty = jObj.Qty;
        inventoryItem.Make = jObj.Make;
        return inventoryItem;
    }

}
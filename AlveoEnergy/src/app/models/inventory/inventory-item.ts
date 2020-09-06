import { ModelBase } from '../model-base';

export class InventoryItem extends ModelBase {
    public Name: string;
    public Make: string;
    public PartNumber: string;
    public Qty: number;

    //UIProperties
    public isExpanded: boolean;

    constructor() {
        super();

    }

    ToJson(): string {
        return JSON.stringify(this);
    }

    static FromJson(jObj: any): InventoryItem {
        var inventoryItem = new InventoryItem();
        inventoryItem.ID = jObj.ID;
        inventoryItem.Name = jObj.Name;
        inventoryItem.PartNumber = jObj.PartNumber;
        inventoryItem.Qty = jObj.Qty;
        inventoryItem.Make = jObj.Make;
        return inventoryItem;
    }

}
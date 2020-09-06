import { ModelBase } from '../model-base';

export class InventoryType extends ModelBase{
    public PartNumber: string;
    public Qty: number;

    constructor() {
        super();
    }

    ToJson(): string {
        return JSON.stringify(this);
    }

    static FromJson(jObj: any): InventoryType {
        var inventoryType = new InventoryType();
        inventoryType.ID = jObj.ID;
        inventoryType.Name = jObj.Name;
        inventoryType.PartNumber = jObj.PartNumber;
        inventoryType.Qty = jObj.Qty;
        return inventoryType;
    }
}
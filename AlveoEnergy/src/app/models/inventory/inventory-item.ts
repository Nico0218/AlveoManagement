import { ModelBase } from '../model-base';
import { InventoryType } from './inventory-type';

export class InventoryItem extends ModelBase {
    public Make: string;
    public Types: InventoryType[];

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
        inventoryItem.Make = jObj.Make;
        inventoryItem.Types = jObj.Subjects as InventoryType[];
        return inventoryItem;
    }

}
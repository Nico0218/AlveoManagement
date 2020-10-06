
export class ModelItem  {
    public ID: string;
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
    }

    ToJson(): string {
        return JSON.stringify(this);
    }

    static FromJson(jObj: any): ModelItem {
        var inventoryItem = new ModelItem();
        inventoryItem.ID = jObj.ID;
        inventoryItem.Name = jObj.Name;
        inventoryItem.PartNumber = jObj.PartNumber;
        inventoryItem.Qty = jObj.Qty;
        inventoryItem.Make = jObj.Make;
        return inventoryItem;
    }

}
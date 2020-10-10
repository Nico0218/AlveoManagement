
export class ModelItem  {
    public ID: number;
    public Name: string;
    public Supplier: string;
    public PartNumber: string;
    public Qty: number;
    public Cost: number;
    public Instock: number;
    public Req: number;
    public Unit: string;
    public Category: number;


    constructor() {
    }

    ToJson(): string {
        return JSON.stringify(this);
    }

    static FromJson(jObj: any): ModelItem {
        var inventoryItem = new ModelItem();
        inventoryItem.ID = jObj.ID;
        inventoryItem.Name = jObj.Name;
        inventoryItem.Supplier = jObj.Supplier;
        inventoryItem.PartNumber = jObj.Partnumber;
        inventoryItem.Qty = jObj.Qty;
        inventoryItem.Cost = jObj.Cost;
        inventoryItem.Instock = jObj.Instock;
        inventoryItem.Req = jObj.Req;
        inventoryItem.Unit = jObj.Unit;
        inventoryItem.Category = jObj.Category;
        return inventoryItem;
    }

}
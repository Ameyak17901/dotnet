namespace BOL;

public class Product{
    public int ProductId {get;set;}
    public string Title {get;set;}
    public string Picture{get;set;}
    public string Description {get;set;}
    public int UnitPrice {get;set;}
    public bool Available {get;set;}
    public int CategoryId {get;set;}
    public int UnitInStock {get;set;}


    public Product(int productid, string title, string picture, string description, int unitprice, bool available,int categoryid, int unitinstock){
        this.ProductId = productid;
        this.Title = title;
        this.Picture = picture;
        this.Description = description;
        this.UnitPrice = unitprice;
        this.Available = available;
        this.CategoryId = categoryid;
        this.UnitInStock = unitinstock;
    }    

}
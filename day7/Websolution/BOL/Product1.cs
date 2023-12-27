namespace BOL;

public class Product
{
    private int id;
    private string title;
    private string picture;
    private string description;
    private int unitPrice;
    private int available;
    private int categoryId;
    private int unitInStock;


    public Product(){
    }

    public Product(int productId, string title){
        this.id = productId;
        this.title = title;
        
    }

    // public Product(int productId, string title, string brand, string category){
    //     this.id = productId;
    //     this.title = title;       
    //     this.category = category;
    // }

    //  public Product(int productId, string title, string brand,
    //                 string category, float unitPrice, int balance){
    //     this.id = productId;
    //     this.title = title;
    //     this.category = category;
    //     this.unitPrice = unitPrice;
    //     this.balance = balance;
    // }

    public Product(int productId, string title, string brand, string category,
                    float unitPrice, 
                    int balance, string description, string imageURL){
        this.id = productId;
        this.title = title;   
        this.category = category;
        this.unitPrice = unitPrice;
        this.balance = balance;
        this.description = description;
        this.imageURL = imageURL;
    }

    //Properties of Product Entity

    public int ProductId{
        get { return id; }
        set { id = value; }
    }
    
    public string Title{
            get { return title; }
            set { title = value; }
    }


    public int CategoryId{
        get { return categoryId; }
        set { categoryId = value; }
    }
        
    public string Description{
        get { return description; }
        set { description = value; }
    }

    
    public int Available{
        get { return available;}
        set { available = value; }
    }

    public int Delivery {
        get{  return delivery;}
        set{ delivery = value; }
    }

    public string Picture{
        get  {   return picture; }
        set  { picture = value; }
    }

    public float UnitPrice{
        get  { return unitPrice; }
        set  { unitPrice = value; }
    }
    
    public int Balance{
        get{  return balance; }
        set{  balance = value;}
        }
}

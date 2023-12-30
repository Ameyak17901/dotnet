namespace BLL;
using BOL;
using DAL.Connected;


public class CatalogManager{
    public List<Product> GetAllProducts(){
        List<Product> products = DBManager.GetAllProducts();
        return products;
    }

    // public bool UpdateProductDetails(string Title, string Description, int UnitPrice, int CategoryId, int UnitInStock){

    // }   
}
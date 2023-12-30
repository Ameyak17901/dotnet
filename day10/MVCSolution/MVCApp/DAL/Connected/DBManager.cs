namespace DAL.Connected;
using BOL;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

public static class DBManager{

    public static string connString = "server=localhost;port=3306;user=root;password=welcome;database=ecommerce";

    public static List<Product> GetAllProducts(){
        List<Product> allProducts = new List<Product>();
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = connString;
        string query = "select * from products where title in (select distinct(title) from products)";
        MySqlCommand cmd = new MySqlCommand(query,con);
        try{
            con.Open();
            MySqlDataReader reader = cmd.ExecuteReader();

            while(reader.Read()){
                int productid = int.Parse(reader["productid"].ToString());
                string title = reader["title"].ToString();
                string picture = reader["picture"].ToString();
                string description = reader["description"].ToString();
                int unitprice = int.Parse(reader["unitprice"].ToString());
                bool available = bool.Parse(reader["available"].ToString());
                int categoryid = int.Parse(reader["categoryid"].ToString());
                int unitinstock = int.Parse(reader["unitinstock"].ToString());

                Product p = new Product(productid,title,picture,description,unitprice,available,categoryid,unitinstock);

                allProducts.Add(p);
            }
            reader.Close();
        }catch(Exception e){
            Console.WriteLine(e.Message);
        }finally{
            con.Close();
        }

        return allProducts;
    }

    // public static bool UpdateProductDetails(string title, string description, int unitPrice, int categoryId, int unitInStock){
    //     MySqlConnection con = new MySqlConnection();
    //     con.ConnectionString = connString;
    //     string query = "update products set title=@title, description=@description, unitPrice"; 

    // }
}
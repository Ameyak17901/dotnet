namespace DAL.Connected;
using BOL;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

public class DBManager{
    public static string connString = "server=localhost;port=3306;user=root;password=welcome;database=ecommerce";

    public static List<Product> GetAllProducts(){
        List<Product> allProducts = new List<Product>();
        MySqlConnection connection = new MySqlConnection();
        connection.ConnectionString = connString;
        string query = "select * from products";
        try{
            MySqlCommand command = new MySqlCommand();
            command.Connection = connection;
            connection.Open();
            command.CommandText = query;
            MySqlDataReader reader = command.ExecuteReader();

            while(reader.Read()){
                int Id = int.Parse(reader["productid"].ToString());
                string Title = reader["title"].ToString();
                string Picture = reader["picture"].ToString();
                string Description = reader["description"].ToString();
                int UnitPrice = int.Parse(reader["unitprice"].ToString());
                int Available = int.Parse(reader["available"].ToString());
                int CategoryId = int.Parse(reader["categoryid"].ToString());
                int UnitInStock = int.Parse(reader["unitinstock"].ToString());

                Product p = new Product(Id,Title,Picture,Description,UnitPrice,Available,CategoryId,UnitInStock);

                allProducts.add(p);
            }     

        }catch(Exception ee){
            Console.WriteLine(e.Message);
        }finally{
            connection.Close();
        }

        return allProducts;
    }
}   
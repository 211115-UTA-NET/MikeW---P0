using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Project
{
    public class Inventory
    {
        internal string Name { get; set; }
        internal decimal price { get; set; }
        internal int quantity { get; set; }

        public Inventory()
        {
            Name = "nothing yet";
            price = 0;
        }

        public Inventory(string a, int b, decimal c )
        {
            Name = a;
            quantity = b;
            price = c;
            
        }
        public override string ToString()
        {
            return "Name: " + Name + " the price is: $" + price + " each";
        }
        public static void AddNewOrder()
        {
            string location = " ";
            int customerId = 1;
            DateTime orderDate = DateTime.Now;
            string Name = " ";

            string connectionString = File.ReadAllText("C:/Users/mjwaw/Revature/TextFile1.txt");

            using SqlConnection connection = new(connectionString);
            connection.Open();

            using SqlCommand command = new($"INSERT INTO Orders (StoreLocation, CustomerId, OrderDate, ItemName) Values(@location, @customerId, @orderDate, @Name);", connection);
            command.Parameters.AddWithValue("@location", location);
            command.Parameters.AddWithValue("@customerId", customerId);
            command.Parameters.AddWithValue("@orderDate", orderDate);
            command.Parameters.AddWithValue("@itemName", Name);
            command.ExecuteNonQuery();
            connection.Close();
        }


    }
}

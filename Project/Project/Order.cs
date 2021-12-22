using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Project
{
    public class Order
    {
        internal string Name { get; set; }
        internal decimal price { get; set; }
        internal int quantity { get; set; }

        public Order()
        {
            Name = "nothing yet";
            price = 0;
        }

        public Order(string a, int b, decimal c )
        {
            Name = a;
            quantity = b;
            price = c;
            
        }
        public override string ToString()
        {
            return "Name: " + Name + " the price is: $" + price + " each";
        }
            
        public static void AddNewOrderMilwaukee()
        {
            string connectionString = File.ReadAllText("C:/Users/mjwaw/Revature/TextFile1.txt");
            
            string location = "Milwaukee, WI ";
            int customerId = 1;
            DateTime orderDate = DateTime.Now;
            string firstName = " ";
            string lastName = " ";
            

            using SqlConnection connection = new(connectionString);
            connection.Open();

            using SqlCommand command = new($"INSERT INTO Orders (StoreLocation, CustomerId, OrderDate, FirstName, LastName) Values(@location, @customerId, @orderDate, @firstName, @lastName);", connection);
            command.Parameters.AddWithValue("@location", location);
            command.Parameters.AddWithValue("@customerId", customerId);
            command.Parameters.AddWithValue("@orderDate", orderDate);
            command.Parameters.AddWithValue("@firstName", firstName);
            command.Parameters.AddWithValue("@lastName", lastName);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public static void AddNewOrderMadison()
        {
            string location = "Madison, WI ";
            int customerId = 1;
            DateTime orderDate = DateTime.Now;
            string itemName = " ";

            string connectionString = File.ReadAllText("C:/Users/mjwaw/Revature/TextFile1.txt");

            using SqlConnection connection = new(connectionString);
            connection.Open();

            using SqlCommand command = new($"INSERT INTO Orders (StoreLocation, CustomerId, OrderDate, ItemName) Values(@location, @customerId, @orderDate, @itemName);", connection);
            command.Parameters.AddWithValue("@location", location);
            command.Parameters.AddWithValue("@customerId", customerId);
            command.Parameters.AddWithValue("@orderDate", orderDate);
            command.Parameters.AddWithValue("@itemName", itemName);
            command.ExecuteNonQuery();
            connection.Close();
        }


    }
}

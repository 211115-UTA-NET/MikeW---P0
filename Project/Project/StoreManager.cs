using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Project
{
    internal class StoreManager
    {
        public StoreManager()
        {
            string connectionString = File.ReadAllText("C:/Users/mjwaw/Revature/TextFile1.txt");
            using SqlConnection connection = new(connectionString);
            connection.Open();

            string commandText = "SELECT FirstName, LastName From Customers WHERE FirstName = 'Bobby' AND LastName = 'Hill'";

            using SqlCommand command = new(commandText, connection);

            using SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int CustomerId = reader.GetInt32(0);
                string FirstName = reader.GetString(1);
                string LastName = reader.GetString(2);
                

                Console.WriteLine($"In stock in {CustomerId} are {FirstName}, there are {LastName}");
            }
        }
    }
}

//Console.WriteLine("Are you a Store Manager? \n Yes or No?");
//string answer = Console.ReadLine();
//if (answer == "y" || answer == "yes")
//
//      need t create a mehtod here in StoreManager and call it in Main

//{
//    Console.WriteLine("1. Do you want to search for a customer?");
//    Console.WriteLine("2. Do you want to see a customers order history?");
//    Console.WriteLine("3. Do you want to see the order history from a store?");
//    Console.WriteLine("4. Quit application.");
//    string value = Console.ReadLine();
//    while (value != 4)
//    {
//        switch (value)
//        {
//            case 1:
//                Console.WriteLine("Please enter your query.")
//                Console.ReadLine();
                
//                    break;

//        }
//    }
//}

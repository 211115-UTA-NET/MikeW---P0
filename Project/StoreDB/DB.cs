using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Project
{
    public class Program
    {
        public static void Main()
        {

            string connectionString = File.ReadAllText("C:/Users/mjwaw/Revature/TextFile1.txt");
            

            Console.WriteLine("Welcome to the corner store.");
            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();


            //adds a new customer
            AddNewCustomer(firstName, lastName);
            void AddNewCustomer(string firstName, string lastName)
            {
                using SqlConnection connection = new(connectionString);
                connection.Open();

                using SqlCommand command = new($"INSERT INTO Customers (FirstName, LastName) Values(@firstName, @lastName);", connection);
                command.Parameters.AddWithValue("@firstName", firstName);
                command.Parameters.AddWithValue("@lastName", lastName);

                command.ExecuteNonQuery();
                connection.Close();
            }

            //shows customers in the database

            void Customers()
            {
                using SqlConnection connection = new(connectionString);
                connection.Open();
                using IDbCommand command = new SqlCommand("SELECT Customers.CustomerId, Customers.FirstName, Customers.LastName FROM Customers;", connection);
                using IDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int customerId = reader.GetInt32(0);
                    string customerFirstName = reader.GetString(1);
                    string customerLastName = reader.GetString(2);

                    Console.WriteLine($"The customer ID is: {customerId}, their name is {customerFirstName} {customerLastName}");
                }
                connection.Close();
            }

            //shows store inventory
            using SqlConnection connection = new(connectionString);
            connection.Open();

            string commandText = "SELECT * FROM Store";

            using SqlCommand command = new(commandText, connection);

            using SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string Location = reader.GetString(0);
                string ItemName = reader.GetString(1);
                int Quantity = reader.GetInt32(2);
                decimal Price = reader.GetDecimal(3);

                Console.WriteLine($"In stock in {Location} are {ItemName}, there are {Quantity}, each one costs ${Price}");
            }
        }


        //public class Practice
        //    {
        //    private int input;
        //    public Practice()
        //    {
        //        Console.WriteLine("Welcome to the corner store. \n What do you want to do?");
        //        Console.WriteLine("1. Buy Groceries.");
        //        Console.WriteLine("2. Leave");

        //        input = int.Parse(Console.ReadLine());

        //        while (input != 2)
        //        {
        //            switch (input)
        //            {
        //                case 1:
        //                    Program.AddNewCustomer();
        //                    break;
        //            }
        //        }


        //    }


        //}
    }
}





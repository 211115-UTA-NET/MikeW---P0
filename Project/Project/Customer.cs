using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Project
{
    public class Customer : Person
    {
        public Customer(int customerId, string firstName, string lastName) : base(firstName, lastName)
        {
            

            
        }
            public static void AddNewCustomer(string firstName, string lastName)
            {
            string connectionString = File.ReadAllText("C:/Users/mjwaw/Revature/TextFile1.txt");
                using SqlConnection connection = new(connectionString);
                connection.Open();

                using SqlCommand command = new($"INSERT INTO Customers (FirstName, LastName) Values(@firstName, @lastName);", connection);
                command.Parameters.AddWithValue("@firstName", firstName);
                command.Parameters.AddWithValue("@lastName", lastName);

                command.ExecuteNonQuery();
                connection.Close();
            }
    }
}


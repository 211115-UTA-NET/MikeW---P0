
using System.Data;
using System.Data.SqlClient;




string connectionString = File.ReadAllText("C:/Users/mjwaw/Revature/TextFile1.txt");
using SqlConnection connection = new(connectionString);
connection.Open();

string commandText = "SELECT * FROM Inventory"; 

using SqlCommand command = new(commandText, connection);

using SqlDataReader reader = command.ExecuteReader();

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
Customers();
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

while (reader.Read())
{
    string ItemName = reader.GetString(0);
    int Quantity = reader.GetInt32(1);
    decimal Price = reader.GetDecimal(2);

    Console.WriteLine($"In stock are {ItemName} and there are {Quantity}, each one costs ${Price}");
}
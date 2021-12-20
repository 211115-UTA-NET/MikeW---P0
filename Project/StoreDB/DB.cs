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

AddNewCustomer(firstName, lastName);

void AddNewCustomer( string firstName, string lastName)
{
    using SqlConnection connection = new(connectionString);
    connection.Open();

    using SqlCommand command = new($"INSERT INTO Customers (FirstName, LastName) Values(@firstName, @lastName);", connection);
    command.Parameters.AddWithValue("@firstName", firstName);
    command.Parameters.AddWithValue("@lastName", lastName);

    command.ExecuteNonQuery();
    connection.Close();

}
void Customers()
{
    using SqlConnection connection = new(connectionString);
    connection.Open();
    string commandText = @"SELECT Customers.FirstName, Customers.LastName";
    using SqlCommand command = new(commandText, connection);

    using SqlDataAdapter adapter = new(command);
    DataSet dataSet = new();
    adapter.Fill(dataSet);

    connection.Close();


    DataColumn? firstNameColumn = dataSet.Tables[0].Columns[0];
    foreach(DataRow row in dataSet.Tables[0].Rows)
    {
        Console.WriteLine($"{row["FirstName"]}: \"{row["LastName"]}\"");
    }
}



while (reader.Read())
{
    string ItemName = reader.GetString(0);
    int Quantity = reader.GetInt32(1);
    decimal Price = reader.GetDecimal(2);

    Console.WriteLine($"In stock are {ItemName} and there are {Quantity}, each one costs ${Price}");
}

//searching a database for a customer

//string Customer(string FirstName, string LastName);




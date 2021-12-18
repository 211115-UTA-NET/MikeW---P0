using System.Data.SqlClient;


string connectionString = File.ReadAllText(File.);
using SqlConnection connection = new(connectionString);
connection.Open();

string commandText = "SELECT * FROM PROJECT0";

using SqlCommand command = new(commandText, connection);

using SqlDataReader reader = command.ExecuteReader();


while (reader.Read())
{
    string Inventory = reader.GetString(0);

    decimal Price = reader.GetDecimal(1);

    Console.WriteLine($"{Inventory} and {Price}");
}
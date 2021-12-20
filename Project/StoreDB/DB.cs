using System.Data.SqlClient;



string connectionString = File.ReadAllText("C:/Users/mjwaw/Revature/TextFile1.txt");
using SqlConnection connection = new(connectionString);
connection.Open();

string commandText = "SELECT * FROM Inventory"; 

using SqlCommand command = new(commandText, connection);

using SqlDataReader reader = command.ExecuteReader();


while (reader.Read())
{
    string ItemName = reader.GetString(0);
    int Quantity = reader.GetInt32(1);
    decimal Price = reader.GetDecimal(2);

    Console.WriteLine($"{ItemName} and {Quantity} and {Price}");
}
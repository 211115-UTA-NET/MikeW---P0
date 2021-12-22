﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Project
{
	public class Store
	{
		public List<Inventory> InventoryList { get; set; }
		public List<Inventory> ShoppingList { get; set; }
		public Store()
		{
			InventoryList = new List<Inventory>();
			ShoppingList = new List<Inventory>();
		}
		public decimal Checkout()
		{
			decimal totalCost = 0;

			foreach (var b in ShoppingList)
			{
				totalCost += b.price;

			}
			ShoppingList.Clear();
			return totalCost;
		}
		public static void  StoreInventory()
        {
			string connectionString = File.ReadAllText("C:/Users/mjwaw/Revature/TextFile1.txt");

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
	}
}
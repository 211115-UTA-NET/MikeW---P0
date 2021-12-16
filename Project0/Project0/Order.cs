using System;

namespace Project
{	
	public class Order
	{
		private string Product { get; set; }
		private int Quantity { get; set; }

		// use a list 
		public Order(string product, int quantity)
		{
			this.Product = product;
			this.Quantity = quantity;
		}
	}
}


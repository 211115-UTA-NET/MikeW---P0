using System;

namespace Project
{	
	public class Order
	{
		private string product { get; set; }
		private int quantity { get; set; }
		public Order(string product, int quantity)
		{
			this.product = product;
			this.quantity = quantity;
		}
	}
}


using System;

namespace Project
{
	public class Store
	{
		private string Location { get; set; }
		private int Inventory { get; set; }
		public Store(string location, int inventory)
		{
			this.Location = location;
			this.Inventory = inventory;
		}
	}
}


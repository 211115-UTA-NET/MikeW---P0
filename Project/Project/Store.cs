using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            foreach (var c in ShoppingList)
            {
                totalCost = totalCost + c.Price;
            }
            ShoppingList.Clear();

            return totalCost;
        }
       
    }
}

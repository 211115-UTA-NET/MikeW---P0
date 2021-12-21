using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Order
    {
        //create a shopping cart?

        internal List<Inventory> InventoryList { get; set; }
        internal List<Inventory> ShoppingList { get; set; }
        
        public Order()
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

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
            //var InventoryList = new List<string>();
            //InventoryList.Add("Apples");
            //InventoryList.Add("Bananas");
            //InventoryList.Add("Bread");
            //InventoryList.Add("Milk");
            //InventoryList.Add("Chicken Pieces");
            //InventoryList.Add("Potato Chips");
            //InventoryList.Add("Pizza");
            //InventoryList.Add("Chocolate Chip Cookies");
            //InventoryList.Add("Salad");
            //InventoryList.Add("Oranges");


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

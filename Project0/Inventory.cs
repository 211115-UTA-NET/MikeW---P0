using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Inventory
    {
        private string itemName { get; set; }
        private decimal price { get; set; }

        public Inventory()
        {
            this.itemName = "nothing yet";
            this.price = 0.00M;
        }

        public Inventory(string a, decimal b)
        {
            this.itemName = a;
            this.price = b;
        }
    }
}

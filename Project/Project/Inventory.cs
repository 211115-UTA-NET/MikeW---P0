using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Inventory
    {
        //public int ItemId { get; set; }
       public string Name { get; set; }
       public decimal Price { get; set; }

        public Inventory ()
        {
            //ItemId = 0;
            Name = "nothing yet";
            Price = 0.00M;  
        }

        public Inventory(string b, decimal c)
        {
            //ItemId = a;
            Name = b;
            Price = c;
        }

        override public string ToString()
        {
            return "Name: " + Name + " Price: $" + Price;
        }
    }
}

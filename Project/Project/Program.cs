using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Project
    {
        static void Main(string[] args)
        {
            
            Store store = new Store();
            
            Console.WriteLine("Welcome to The Corner Store. \n Please enter your first name.");
            Console.ReadLine();
            Console.WriteLine("Please enter your last name.");
            Console.ReadLine();
            Console.WriteLine("What do you want to buy?");
            

            int action = chooseAction();

            while(action != 0)
            {
                Console.WriteLine($"You chose: {action}");

                switch(action)
                {
                    case 1:
                        Console.WriteLine("You chose to add an item to your cart.");
                        // itemId = 0;
                        //String itemName = "";

                        //Console.WriteLine("What is the item Id?  123, 456");
                        //itemId = int.Parse(Console.ReadLine());

                        Console.WriteLine("What is the item name? apples, bananas");
                        string itemName = Console.ReadLine();

                        Console.WriteLine("What is the item price?");
                        decimal itemPrice = decimal.Parse(Console.ReadLine());

                        Inventory newOrder = new Inventory(itemName, itemPrice);
                        store.InventoryList.Add(newOrder);

                        printInventory(store);
                        break;


                    case 2:
                        Console.WriteLine("You chose to add an item to your cart.");
                        printInventory(store);
                        Console.WriteLine("Which item would you liek to buy? (number)");
                        int itemChosen = int.Parse(Console.ReadLine());

                        store.ShoppingList.Add(store.InventoryList[itemChosen]);

                        printShoppingCart(store);
                        break;

                    case 3:
                        printShoppingCart(store);
                        Console.WriteLine($"the total cost of your items is: {store.Checkout}");
                        break;

                    default:
                        break;
                }

                action = chooseAction();
            }
        }

        private static void printShoppingCart(Store store)
        {
            Console.WriteLine("Items you have chosen to buy: ");
            for (int i = 0; i < store.ShoppingList.Count; i++)
            {
                Console.WriteLine($"Item #: " + i + " " + store.ShoppingList[i]);
            }
        }

        private static void printInventory(Store store)
        {
            for(int i = 0; i < store.InventoryList.Count; i++)
            {
                Console.WriteLine($"Item #: " + i + " " + store.InventoryList[i]);
            }
        }

        static public int chooseAction()
        {
            int choice = 0;
            Console.WriteLine("Choose an action (0) to quit, (1) to buy items, (2) add to cart (3) checkout.");
            
            choice = int.Parse(Console.ReadLine());
            return choice;
        
        }
    }
}
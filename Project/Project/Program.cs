using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Project
{
    class Project
    {
        static void Main(string[] args)
        {

            Store store = new Store();

            Console.WriteLine("Welcome to The Corner Store. \n Please enter your first name.");
            try
            {
                var firstName = Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("Please enter your last name.");
            try
            {
                var lastName = Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            Console.WriteLine();

            int action = chooseAction();

            while (action != 0)
            {
                Console.WriteLine($"You chose: {action}");


                switch (action)
                {
                    case 1: 
                        Store.StoreInventory();
                        break;

                    case 2:
                        Console.WriteLine("You chose to add an item to your cart.");
                       

                        Console.WriteLine("What is the item name? apples, bananas, etc.");
                        string itemName = Console.ReadLine();

                        Console.WriteLine("How many do you want to add to your cart?");
                        int quantity = int.Parse(Console.ReadLine());

                        Console.WriteLine("What is the cost of the item?");
                        int price = int.Parse(Console.ReadLine());

                        Inventory newOrder = new Inventory(itemName, quantity, price );
                        store.InventoryList.Add(newOrder);

                        printInventory(store);
                        break;


                    case 3:
                        Console.WriteLine("You chose to add an item to your cart.");
                        printInventory(store);
                        Console.WriteLine("Which item would you like to buy? (number)");
                        int itemChosen = int.Parse(Console.ReadLine());

                        store.ShoppingList.Add(store.InventoryList[itemChosen]);

                        printShoppingCart(store);
                        break;

                    case 4:
                        printShoppingCart(store);
                        Inventory.AddNewOrder();
                        Console.WriteLine($"The total cost of your items is: ${store.Checkout()}");
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
                Console.WriteLine("Item #: " + i + " " + store.ShoppingList[i]);
            }
        }

        private static void printInventory(Store store)
        {
            for(int i = 0; i < store.InventoryList.Count; i++)
            {
                Console.WriteLine("Item #: " + i + " " + store.InventoryList[i]);
            }
        }

        static public int chooseAction()
        {
            int choice = 0;
            Console.WriteLine("Choose an action:\n 0) Quit.\n 1) Show Inventory 2) Buy items, \n 3) Add Items to Cart, \n 4) Checkout.");
            
            choice = int.Parse(Console.ReadLine());
            return choice;
        }
    }
}
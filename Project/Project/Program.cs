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
            string connectionString = File.ReadAllText("C:/Users/mjwaw/Revature/TextFile1.txt");

            using SqlConnection connection = new(connectionString);

            Store store = new Store();

            //Console.WriteLine("Are you a Store Manager? \n Yes or No?");
            //string answer = Console.ReadLine();
            //if (answer == "y" || answer == "yes")
            //{

            //    Console.WriteLine("1. Do you want to search for a customer?");
            //    Console.WriteLine("2. Do you want to see a customers order history?");
            //    Console.WriteLine("3. Do you want to see the order history from a store?");
            //    Console.WriteLine("4. Back to Menu");
            //    int value = Convert.ToInt32(Console.ReadLine());

            //    if (value!= 4)                
            //       {
            //            Console.WriteLine("Please enter your query.");

            //            connection.Open();
            //            SqlCommand command;
            //            SqlDataReader dataReader;
            //            String sql, Output = " ";
            //            sql = Console.ReadLine();
            //            command = new SqlCommand(sql, connection);
            //            dataReader = command.ExecuteReader();
            //            while (dataReader.Read())
            //            {
            //                Output = Output + dataReader.GetValue(0) + "  " + dataReader.GetValue(1) + "\n";
            //            }
            //            Console.WriteLine(Output);
            //            dataReader.Close();
            //            command.Dispose();
            //            connection.Close();


            //    }

            //}
            //else
            //{

            Console.WriteLine("Welcome to The Corner Store. \n Please enter your first name.");

            string firstName = Convert.ToString(Console.ReadLine());


            Console.WriteLine("Please enter your last name.");

            string lastName = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Which store do you want to shop at? \n 1) Milwaukee \n 2) Maidson");
            int input = int.Parse(Console.ReadLine());

            int action = chooseAction();


            AddNewCustomer(firstName, lastName);
            void AddNewCustomer(string firstName, string lastName)
            {
                using SqlConnection connection = new(connectionString);
                connection.Open();

                using SqlCommand command = new($"INSERT INTO Customers (FirstName, LastName) Values(@firstName, @lastName);", connection);
                command.Parameters.AddWithValue("@firstName", firstName);
                command.Parameters.AddWithValue("@lastName", lastName);

                command.ExecuteNonQuery();
                connection.Close();


                if (input == 1)
                {

                    while (action != 0)
                    {
                        Console.WriteLine($"You chose: {action}");


                        switch (action)
                        {
                            case 1:
                                Store.StoreInventoryMilwaukee();
                                break;

                            case 2:
                                Console.WriteLine("You chose to add an item to your cart.");


                                Console.WriteLine("What is the item name? apples, bananas, etc.");
                                string itemName = Console.ReadLine();

                                Console.WriteLine("How many do you want to add to your cart?");
                                int quantity = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine("What is the cost of the item?");
                                int price = Convert.ToInt32(Console.ReadLine());

                                Order newOrder = new Order(itemName, quantity, price);
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
                                void AddNewOrderMilwaukee()
                                {
                                    string connectionString = File.ReadAllText("C:/Users/mjwaw/Revature/TextFile1.txt");

                                    string storeLocation = "Milwaukee, WI ";
                                    int orderId = 1;
                                    DateTime orderDate = DateTime.Now;
                                    //string firstName = " ";
                                    //string lastName = " ";


                                    using SqlConnection connection = new(connectionString);
                                    connection.Open();

                                    using SqlCommand command = new($"INSERT INTO Orders (StoreLocation, OrderId, OrderDate, FirstName, LastName) Values(@storeLocation, @orderId, @orderDate, @firstName, @lastName);", connection);
                                    command.Parameters.AddWithValue("@storeLocation", storeLocation);
                                    command.Parameters.AddWithValue("@orderId", orderId);
                                    command.Parameters.AddWithValue("@orderDate", orderDate);
                                    command.Parameters.AddWithValue("@firstName", firstName);
                                    command.Parameters.AddWithValue("@lastName", lastName);
                                    command.ExecuteNonQuery();
                                    connection.Close();
                                }
                                Console.WriteLine($"The total cost of your items is: ${store.Checkout()}");
                                break;

                            default:
                                break;
                        }
                        action = chooseAction();
                    }


                    if (input == 2)
                    {
                        while (action != 0)
                        {
                            Console.WriteLine($"You chose: {action}");

                            switch (action)
                            {
                                case 1:
                                    Store.StoreInventoryMadison();
                                    break;

                                case 2:
                                    Console.WriteLine("You chose to add an item to your cart.");


                                    Console.WriteLine("What is the item name? apples, bananas, etc.");
                                    string itemName = Console.ReadLine();

                                    Console.WriteLine("How many do you want to add to your cart?");
                                    int quantity = int.Parse(Console.ReadLine());

                                    Console.WriteLine("What is the cost of the item?");
                                    int price = int.Parse(Console.ReadLine());

                                    Order newOrder = new Order(itemName, quantity, price);
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
                                    void AddNewOrderMadison()
                                    {
                                        string storeLocation = "Madison, WI ";
                                        int orderId = 1;
                                        DateTime orderDate = DateTime.Now;
                                        //string firstName = " ";
                                        //string lastName = " ";

                                        string connectionString = File.ReadAllText("C:/Users/mjwaw/Revature/TextFile1.txt");

                                        using SqlConnection connection = new(connectionString);
                                        connection.Open();

                                        using SqlCommand command = new($"INSERT INTO Orders (StoreLocation, OrderId, OrderDate, FirstName, LastName) Values(@storeLocation, @orderId, @orderDate, @firstName, @lastName);", connection);
                                        command.Parameters.AddWithValue("@storeLocation", storeLocation);
                                        command.Parameters.AddWithValue("@orderId", orderId);
                                        command.Parameters.AddWithValue("@orderDate", orderDate);
                                        command.Parameters.AddWithValue("@firstName", firstName);
                                        command.Parameters.AddWithValue("@lastName", lastName);
                                        command.ExecuteNonQuery();
                                        connection.Close();
                                    }
                                    Console.WriteLine($"The total cost of your items is: ${store.Checkout()}");
                                    break;

                                default:
                                    break;
                            }

                            action = chooseAction();
                        }

                    }
                }
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
            for (int i = 0; i < store.InventoryList.Count; i++)
            {
                Console.WriteLine("Item #: " + i + " " + store.InventoryList[i]);
            }
        }

        static public int chooseAction()
        {
            int choice = 0;
            Console.WriteLine("Choose an action:\n 0) Quit.\n 1) Show Inventory \n 2) Add items to Cart, \n 3) Buy Items, \n 4) Checkout.");
            try
            {
                choice = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return choice;
        }
    }
}




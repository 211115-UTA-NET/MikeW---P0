using System;

namespace Project
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Customer Mike = new Customer("Mike", "Wawrzyniak");


            Store Grocery = new Store("Grocery", 120);
            Order shoppingList = new Order("apples", 12);
            Console.WriteLine(Mike);
        }
    }
}
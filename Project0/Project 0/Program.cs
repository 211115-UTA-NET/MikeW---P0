﻿using System;

namespace Project
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Customer Mike = new Customer("Mike", "Wawrzyniak");
            Store store = new Store();
            Order order1 = new Order("apples", 12);
            Console.WriteLine();
        }
    }
}
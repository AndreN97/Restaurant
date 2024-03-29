﻿using System;
using System.Collections.Generic;
using System.Threading;
using Restaurant.Domain;
using static System.Console;

namespace Restaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            RestaurantX restaurant = new RestaurantX("MaxDonalds");
            bool shouldRun = true;

            while (shouldRun)
            {
                Clear();

                WriteLine("1. Add order");
                WriteLine("2. List orders");
                WriteLine("3. Exit");

                ConsoleKeyInfo keyPressed = ReadKey(true);

                switch (keyPressed.Key)
                {
                    case ConsoleKey.D1:

                        Clear();

                        Write("Dish: ");
                        string dish = ReadLine();

                        Write("Table: ");
                        string table = ReadLine();

                        Order newOrder = new Order(dish, table);

                        restaurant.RegisterOrder(newOrder);

                        Clear();

                        WriteLine("Order registered");
                        Thread.Sleep(2000);

                        break;

                    case ConsoleKey.D2:

                        Clear();

                        WriteLine("Table   Dish                                      Registered");
                        WriteLine("------------------------------------------------------------");

                        foreach (var order in restaurant.OrderQueue)
                        {
                            WriteLine($"{order.Table}   {order.Dish}                                 {order.RegisteredAt}");
                        }

                        WriteLine();
                        WriteLine("<Press any key to continue>");
                        ReadKey(true);

                        break;

                    case ConsoleKey.D3:
                        shouldRun = false;
                        break;

                    default:
                        break;
                }
            }
        }
    }
}

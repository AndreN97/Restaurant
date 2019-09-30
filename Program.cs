using System;
using static System.Console;

namespace Restaurant
{
    class Program
    {
        static void Main(string[] args)
        {

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

                        break;

                    case ConsoleKey.D2:

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

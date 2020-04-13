using System;
using System.Threading;

namespace Async_and_await
{
    public static class BaseCoffeeShop
    {
        public static void PrepareCoffee()
        {
            Console.WriteLine("Preparing coffee in progress");
            Console.WriteLine(".... Time it takes to prepare coffee (sleep) ....");
            Thread.Sleep(10000);
            Console.WriteLine("The coffee is ready! \n");
        }

        public static void PrepareSandwich()
        {
            Console.WriteLine("Looking for sandwich ....");
            Console.WriteLine(".... Time it takes to looking sandwich (sleep) ....");
            Thread.Sleep(10000);
            Console.WriteLine("Sandwich is on the table! \n");
        }
    }
}

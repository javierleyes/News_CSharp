using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Async_and_await
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();

            Console.WriteLine("********************* Sequential and Synchronous ********************* \n");

            sw.Start();
            CoffeeShopSynchronic.PrepareCoffee();
            CoffeeShopSynchronic.PrepareSandwich();
            sw.Stop();


            Console.WriteLine($"Time elapsed: {sw.Elapsed} \n");

            Console.WriteLine("********************* Sequential and Asynchronous ********************* \n");
            sw.Restart();

            await CoffeeShopAsynchronic.PrepareCoffeeAsync();
            await CoffeeShopAsynchronic.PrepareSandwichAsync();

            sw.Stop();

            Console.WriteLine($"Time elapsed: {sw.Elapsed} \n");


            Console.WriteLine("********************* Parallel and Asynchronous ********************* \n");
            sw.Restart();

            var taskCoffee = CoffeeShopAsynchronic.PrepareCoffeeAsync();
            var taskSandwich = CoffeeShopAsynchronic.PrepareSandwichAsync();

            await Task.WhenAll(taskCoffee, taskSandwich);

            sw.Stop();

            Console.WriteLine($"Time elapsed: {sw.Elapsed} \n");
        }
    }
}

/* Output
 
 ********************* Sequential and Synchronous *********************

Preparing coffee in progress
.... Time it takes to prepare coffee (sleep) ....
The coffee is ready!

Looking for sandwich ....
.... Time it takes to looking sandwich (sleep) ....
Sandwich is on the table!

Time elapsed: 00:00:20.0087122

********************* Sequential and Asynchronous *********************

Preparing coffee in progress
.... Time it takes to prepare coffee (sleep) ....
The coffee is ready!

Looking for sandwich ....
.... Time it takes to looking sandwich (sleep) ....
Sandwich is on the table!

Time elapsed: 00:00:20.1082416

********************* Parallel and Asynchronous *********************

Preparing coffee in progress
.... Time it takes to prepare coffee (sleep) ....
Looking for sandwich ....
.... Time it takes to looking sandwich (sleep) ....
The coffee is ready!

Sandwich is on the table!

Time elapsed: 00:00:10.0137451

*/

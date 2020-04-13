using System;
using System.Threading.Tasks;

namespace Async_and_await
{
    public static class CoffeeShopAsynchronic
    {
        /* I must use the async and await keyword */
        public static async Task PrepareCoffeeAsync()
        {
            /* Create a new thread or consume the asynchronous method */
            await Task.Run(() =>
            {
                BaseCoffeeShop.PrepareCoffee();
            });
        }

        public static async Task PrepareSandwichAsync()
        {
            await Task.Run(() =>
            {
                BaseCoffeeShop.PrepareSandwich();
            });
        }
    }
}


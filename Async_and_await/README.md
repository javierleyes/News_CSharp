# When to use it ?

We must use it when we use something external to our code, for example: database, APIs, File.



## Fire and Forget

Throw task without await

```
CoffeeShopAsynchronic.PrepareSandwichAsync();
```

## ContinueWith

You can chaining dependent Tasks, that is util for example when we consuming API 

```
public static async Task<bool> IsThereDebt()
{
    return await Task.Run(() =>
    {
        /* Authentication token */
        return "A3435ERfdgd-345345dr-dffdf-dffdfd";
    }).ContinueWith(previousTask =>
    {
        Console.WriteLine($"Done! The user is: {previousTask.Result}");
        return true;
    });
}
```
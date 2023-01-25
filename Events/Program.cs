Stock stock = new Stock("Amazon");
stock.Price = 1000;

stock.OnPriceChanged += Stock_OnPriceChanged;

Console.WriteLine($"stock before changing: ${stock.Price}");
stock.ChangeStockPriceBy(0.05m);
stock.ChangeStockPriceBy(-0.05m);
stock.ChangeStockPriceBy(0.00m);
Console.WriteLine($"stock after changing: ${stock.Price}");

void Stock_OnPriceChanged(Stock stock, decimal oldPrice)
{
    if (stock.Price > oldPrice)
        Console.ForegroundColor = ConsoleColor.Green;
    else if (stock.Price < oldPrice)
        Console.ForegroundColor = ConsoleColor.Red;
    else
        Console.ForegroundColor = ConsoleColor.Gray;

    Console.WriteLine($"{stock.Name}: {stock.Price}");
}


//Event has strong relation with delegate

// Event type must be delegate
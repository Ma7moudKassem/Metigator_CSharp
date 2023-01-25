namespace Events;

public class Stock
{
    private string name;
    private decimal price;

    public event StockPriceChangeHundler OnPriceChanged;

    public string Name => name;
    public decimal Price
    {
        get => price;
        set => price = value;
    }

    public Stock(string stockName) => name = stockName;
    public void ChangeStockPriceBy(decimal percent)
    {
        decimal oldPrice = this.price;
        this.price += Math.Round(this.price * percent, 2);

        if (OnPriceChanged != null)
            OnPriceChanged(this, oldPrice);
    }
}

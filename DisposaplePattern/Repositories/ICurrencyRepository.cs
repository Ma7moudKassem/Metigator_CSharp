namespace DisposaplePattern;

public interface ICurrencyRepository : IDisposable
{
    Task<string> GetCurrencies();
}

namespace DisposaplePattern;

public class CurrencyRepository : ICurrencyRepository
{
    private readonly HttpClient _httpClient;
    private bool _disposed = false;
    public CurrencyRepository(HttpClient httpClient) => _httpClient = httpClient;

    ~CurrencyRepository()
        => Dispose(false);
    public async Task<string> GetCurrencies()
    {
        string result = await _httpClient.GetStringAsync("https://coinbase.com/api/v2/currencies");

        return result;
    }

    protected virtual void Dispose(bool disposing)
    {
        if (_disposed) return;

        if (disposing)
            _httpClient.Dispose();

        _disposed = true;
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
}

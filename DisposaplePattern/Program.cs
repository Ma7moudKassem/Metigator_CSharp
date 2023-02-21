HttpClient httpClient = new();

using ICurrencyRepository currencyRepository = new CurrencyRepository(httpClient);

string result = await currencyRepository.GetCurrencies();
Console.WriteLine(result);
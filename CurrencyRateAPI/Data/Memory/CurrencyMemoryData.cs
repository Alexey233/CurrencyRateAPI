using CurrencyRateAPI.Models;
using Newtonsoft.Json;

namespace CurrencyRateAPI.Data.Memory
{
    public class CurrencyMemoryData
    {
        public async Task<Currency> GetListCurrencyAsync()
        {
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetStringAsync("https://www.cbr-xml-daily.ru/daily_json.js");
                var resultCurrency = JsonConvert.DeserializeObject<Currency>(response); 

                return resultCurrency;
            }
        }

    }
}

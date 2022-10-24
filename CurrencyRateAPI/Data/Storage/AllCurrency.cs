using CurrencyRateAPI.Data.Interfaces;
using CurrencyRateAPI.Data.Memory;
using CurrencyRateAPI.Models;
using System.ComponentModel;

namespace CurrencyRateAPI.Data.Storage
{
    public class AllCurrency : IAllCurrency
    {
        CurrencyMemoryData currencyMemory = new CurrencyMemoryData();

        public async Task<IEnumerable<Valute>> GetCurrency(int? pageNumber = null, int? pageSize = null)
        {
            var currency = await currencyMemory.GetListCurrencyAsync();

            var resultValutes = currency.Valute.Values.ToList()
                        .Skip(((pageNumber ?? 1) - 1) * pageSize ?? 5)
                        .Take(pageSize ?? 5); 

                        
            return resultValutes;
        }

        public async Task<Valute> GetObjectCurrency(string nameKey)
        {
            var currency = await currencyMemory.GetListCurrencyAsync();

            var objectCurrency = currency.Valute.FirstOrDefault(k=>k.Key == nameKey).Value;
          
            return objectCurrency;
        }
    }
}

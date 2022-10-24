using CurrencyRateAPI.Models;

namespace CurrencyRateAPI.Data.Interfaces
{
    public interface IAllCurrency
    {
        public Task<IEnumerable<Valute>> GetCurrency(int? pageNumber = null, int? pageSize = null);
        public Task<Valute> GetObjectCurrency(string nameKey);
    }
}

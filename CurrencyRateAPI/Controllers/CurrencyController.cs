using CurrencyRateAPI.Data.Interfaces;
using CurrencyRateAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CurrencyRateAPI.Controllers
{
    [ApiController]
    public class CurrencyController : ControllerBase
    {
        private readonly IAllCurrency _allCurrency;
        public CurrencyController(IAllCurrency allCurrency)
        {
            _allCurrency = allCurrency;
        }

        [Route("api/currencies")]
        [HttpGet]
        public async Task<IEnumerable<Valute>> Currencies(int? pageNumber = null, int? pageSize = null)
        {
            return await _allCurrency.GetCurrency(pageNumber, pageSize);
        }

        [Route("api/currency")]
        [HttpGet]
        public async Task<Valute> Currency(string nameKey)
        {
            return await _allCurrency.GetObjectCurrency(nameKey);
        }

    }
}

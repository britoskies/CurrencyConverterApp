using Microsoft.AspNetCore.Mvc;
using Application.ViewModel;
using Application.Services;

namespace CoinConverter.Controllers
{
    public class CoinConverterController : Controller
    {
        private readonly Converters ConvertersService;

        public CoinConverterController() 
        {
            ConvertersService = new Converters();
        }

        [HttpGet]
        public IActionResult Index(ConverterViewModel vm)
        {
            if (vm.RateToConvert == "peso" && vm.RateToConvertTo == "dolar")
            {
                vm.Result = ConvertersService.ConvertFromPesosToDollar(vm.Amount);
            }

            if (vm.RateToConvert == "dolar" && vm.RateToConvertTo == "peso")
            {
                vm.Result = ConvertersService.ConvertFromDollarToPesos(vm.Amount);
            }

            if (vm.RateToConvert == "peso" && vm.RateToConvertTo == "euro")
            {
                vm.Result = ConvertersService.ConvertFromPesosToEuro(vm.Amount);
            }

            if (vm.RateToConvert == "euro" && vm.RateToConvertTo == "peso")
            {
                vm.Result = ConvertersService.ConvertFromEuroToPesos(vm.Amount);
            }

            if (vm.RateToConvert == "dolar" && vm.RateToConvertTo == "euro")
            {
                vm.Result = ConvertersService.ConvertFromDollarToEuro(vm.Amount);
            }

            if (vm.RateToConvert == "euro" && vm.RateToConvertTo == "dolar")
            {
                vm.Result = ConvertersService.ConvertFromEuroToDollar(vm.Amount);
            }

            return View(vm);
        }

    }
}

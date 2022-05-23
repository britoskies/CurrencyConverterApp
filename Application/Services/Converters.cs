using System;

namespace Application.Services
{
    public class Converters
    {
        public double ConvertFromPesosToDollar(double amount)
        { 
            return Rates.PesosToDollarRate * amount;
        }

        public double ConvertFromDollarToPesos(double amount)
        {
            return Rates.DollarToPesosRate * amount;
        }

        public double ConvertFromPesosToEuro(double amount)
        {
            return Rates.PesosToEuroRate * amount;
        }

        public double ConvertFromEuroToPesos(double amount)
        {
            return Rates.EuroToPesosRate * amount;
        }

        public double ConvertFromDollarToEuro(double amount)
        {
            return Rates.DollarToEuroRate * amount;
        }

        public double ConvertFromEuroToDollar(double amount)
        {
            return Rates.EuroToDollarRate * amount;
        }
    }
}

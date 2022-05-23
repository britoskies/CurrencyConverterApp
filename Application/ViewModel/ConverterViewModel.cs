using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModel
{
    public class ConverterViewModel
    {
        public double Amount { get; set; }
        public double Result { get; set; }
        public string RateToConvert { get; set; }
        public string RateToConvertTo { get; set; }
    }
}

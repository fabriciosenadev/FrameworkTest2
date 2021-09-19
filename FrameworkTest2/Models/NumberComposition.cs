using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrameworkTest2.Models
{
    public class NumberComposition
    {
        public int Number { get; set; }
        public List<int> Denominators { get; set; }
        public List<int> PrimeNumbers { get; set; }
        public string OutputDenominators { get; set; }
        public string OutputPrimeNumbers { get; set; }
    }
}

using FrameworkTest2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrameworkTest2.Services
{
    public class NumberCompositionService: INumberCompositionService
    {
        //private readonly NumberComposition _numberComposition;

        //public NumberCompositionService(NumberComposition numberComposition)
        //{
        //    _numberComposition = numberComposition;
        //}

        public NumberComposition CalculateNumberComposition(int number)
        {
            NumberComposition numberComposition = GetNewNumberComposition();
            numberComposition.Number = number;
            numberComposition.Denominators = GetDenominatorsBySpecificInt(numberComposition.Number);
            numberComposition.PrimeNumbers = GetPrimeNumbersByDenominators(numberComposition.Denominators);

            numberComposition.OutputDenominators = ConvertListToString(' ', numberComposition.Denominators);
            numberComposition.OutputPrimeNumbers = ConvertListToString(' ', numberComposition.PrimeNumbers);

            return numberComposition;
        }

        private static List<int> GetDenominatorsBySpecificInt(int number)
        {
            List<int> denominators = new List<int>();
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                    denominators.Add(i);
            }
            return denominators;
        }
        private static List<int> GetPrimeNumbersByDenominators(List<int> denominators)
        {
            List<int> primeNumbers = new List<int>();
            foreach (int denominator in denominators)
            {
                int count = 0;
                for (int i = denominator; i > 0; i--)
                {
                    if (denominator % i == 0)
                        count++;
                }
                if (count == 2)
                    primeNumbers.Add(denominator);
            }
            return primeNumbers;
        }

        private static string ConvertListToString(char separator, List<int> list) => string.Join(separator, list.ToArray());

        private static NumberComposition GetNewNumberComposition() => new NumberComposition();
    }
}

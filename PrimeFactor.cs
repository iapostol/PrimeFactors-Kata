using System.Collections.Generic;

namespace PrimeFactors_Kata
{
    public static class PrimeFactor
    {
        public static IEnumerable<int> FactorsOf(int n)
        {
            var factors = new List<int>();

            for (int divisor = 2; n > 1; divisor++)
                for (; n % divisor == 0; n /= divisor)
                    factors.Add(divisor);

            return factors;
        }
    }
}
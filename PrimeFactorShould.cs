using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using static PrimeFactors_Kata.PrimeFactor;

namespace PrimeFactors_Kata
{
    public class PrimeFactorShould
    {
        [Theory]
        [InlineData("", 1)]
        [InlineData("2", 2)]
        [InlineData("3", 3)]
        [InlineData("2,2", 4)]
        [InlineData("5", 5)]
        [InlineData("2,3", 6)]
        [InlineData("7", 7)]
        [InlineData("2,2,2", 8)]
        [InlineData("3,3", 9)]
        [InlineData("2, 3, 3, 5, 7, 11, 11", 2 * 3 * 3 * 5 * 7 * 11 * 11)]
        public void Generate_Factors_Of_Given_Number(string expected, int actual)
        {
            Assert.Equal(Contains(expected), FactorsOf(actual));
        }

        private static IEnumerable<int> Contains(string expected)
        {
            IEnumerable<int> list = new List<int>();

            if (!string.IsNullOrEmpty(expected))
                list = expected.Split(",").Select(i => int.Parse(i));

            return list;
        }
    }
}
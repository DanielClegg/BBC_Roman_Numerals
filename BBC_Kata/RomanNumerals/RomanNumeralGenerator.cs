#region

using System;
using System.Collections.Generic;
using System.Linq;

#endregion

namespace RomanNumerals
{
    public class RomanNumeralGenerator : IRomanNumeralGenerator
    {
        private readonly Dictionary<string, int> _romanNumeralValues = new Dictionary<string, int>
        {
            {"M", 1000}, {"CM", 900}, {"D", 500}, {"CD", 400}, {"C", 100}, {"XC", 90}, {"L", 50}, {"XL", 40}, {"X", 10},
            {"IX", 9}, {"V", 5}, {"IV", 4},
            {"I", 1}
        };

        public string Generate(int number)
        {
            if (number == 0)
                return "nulla";
            if (number < 0 || number > 3999)
                throw new ArgumentOutOfRangeException("Roman Numeral Generator only accepts values between 0 and 3999");

            var runningTotal = number;
            var numeralString = "";

            foreach (var (key, value) in _romanNumeralValues.OrderByDescending(c => c.Value))
            {
                if (runningTotal <= 0)
                    break;

                if (runningTotal == value)
                {
                    numeralString += key;

                    break;
                }

                if (runningTotal > value)
                {
                    var countOfNumeralsInCurrentTotal = runningTotal / value;
                    var remainder = runningTotal - countOfNumeralsInCurrentTotal * value;

                    runningTotal = remainder;

                    numeralString = numeralString +
                                    string.Concat(Enumerable.Repeat(key, countOfNumeralsInCurrentTotal));
                }
            }

            return numeralString;
        }
    }
}
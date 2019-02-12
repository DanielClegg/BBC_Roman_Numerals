#region

using System;
using System.Collections.Generic;

#endregion

namespace RomanNumerals
{
    public class RomanNumeralGenerator : IRomanNumeralGenerator
    {
        private readonly Dictionary<char, int> _romanNumeralValues = new Dictionary<char, int>
        {
          {'D', 500}, {'C', 100}, {'L', 50}, {'X', 10}, {'V', 5},
          {'I', 1}
        };

        private string Append(string str, int count)
        {
            var returnString = "";
            for (int i = 0; i < count; i++)
            {
                returnString = returnString + str;
            }

            return returnString;
        }
        
        public string Generate(int number)
        {
            var total = number;
            var returnString = "";

            foreach (var numeral in _romanNumeralValues)
            {
                if (total <= 0)
                    break;

                if (total == numeral.Value)
                {
                    returnString += numeral.Key;
                    total = -numeral.Value;
                }

                if (total > numeral.Value)
                {
                    var tempTotal = total / numeral.Value;
                    var remaining = total - (tempTotal * numeral.Value);
                    total = remaining;

                    returnString = returnString + new string(numeral.Key, tempTotal);
                }
            }

            return returnString;
        }
    }
}
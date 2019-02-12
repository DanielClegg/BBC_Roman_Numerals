#region

using System.Collections.Generic;
using System.Linq;

#endregion

namespace RomanNumerals
{
    public class RomanNumeralGenerator : IRomanNumeralGenerator
    {
        private readonly Dictionary<string, int> _romanNumeralValues = new Dictionary<string, int>
        {
            {"M", 1000}, {"CM", 900}, {"D", 500}, {"CD", 400},{"C", 100},{"XC", 90}, {"L", 50}, {"XL", 40},{"X", 10}, {"IX", 9}, {"V", 5},{"IV", 4},
            {"I", 1}
        };

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
                    total = total - numeral.Value;
                    returnString += numeral.Key;
                }


                if (total > numeral.Value)
                {
                    var tempTotal = total / numeral.Value;
                    var remaining = total - tempTotal * numeral.Value;
                    total = remaining;

                    returnString = returnString + string.Concat(Enumerable.Repeat(numeral.Key, tempTotal));
                }
            }

            return returnString;
        }

        private string Append(string str, int count)
        {
            var returnString = "";
            for (var i = 0; i < count; i++) returnString = returnString + str;

            return returnString;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace RomanNumerals
{
    public class RomanNumeralGenerator : IRomanNumeralGenerator
    {

        Dictionary<string, int> _romanNumeralValues = new Dictionary<string, int>() {
            {"I", 1}, 
            {"V",5},
            {"X", 10}, 
            {"L", 50}, 
            {"C", 100}, 
            {"D",500}};
        
        public string Generate(int number)
        {
            foreach (var numeral in _romanNumeralValues)
            {
                if (number == numeral.Value)
                    return numeral.Key;
            }

            return null;
        }
    }
}
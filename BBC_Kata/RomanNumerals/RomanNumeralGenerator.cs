using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace RomanNumerals
{
    public class RomanNumeralGenerator : IRomanNumeralGenerator
    {

        Dictionary<string, int> _romanNumeralValues = new Dictionary<string, int>() {
{"D",500}, {"C", 100}, {"L", 50},    {"X", 10},  {"V",5},
            {"I", 1}
           
         
            
           
            
};
        
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
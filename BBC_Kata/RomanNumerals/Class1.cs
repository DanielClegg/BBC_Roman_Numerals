﻿using System;

namespace RomanNumerals
{
    public class RomanNumeralGenerator : IRomanNumeralGenerator
    {
        public string Generate(int number)
        {
                throw new NotImplementedException();
        }
    }

    public interface IRomanNumeralGenerator
    {
        string Generate(int number);
    }
}

namespace RomanNumerals
{
    public interface IRomanNumeralGenerator
    {
        /// <summary>
        ///     Generates the corresponding Roman numerals from an integer
        /// </summary>
        /// <param name="number" type="integer"></param>
        /// <returns>Roman numerals as a string</returns>
        string Generate(int number);
    }
}
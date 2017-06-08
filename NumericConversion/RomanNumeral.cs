using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DsuDev.NumericConversion
{
    public class RomanNumeral
    {
        protected readonly Dictionary<int, string> baseNumbers;
        protected const int MaxNumber = 4000;

        public RomanNumeral()
        {
            baseNumbers = new Dictionary<int, string>();
            baseNumbers.Add(1, "I");
            baseNumbers.Add(4, "IV");
            baseNumbers.Add(5, "V");
            baseNumbers.Add(9, "IX");
            baseNumbers.Add(10, "X");
            baseNumbers.Add(40, "XL");
            baseNumbers.Add(50, "L");
            baseNumbers.Add(90, "XC");
            baseNumbers.Add(100, "C");
            baseNumbers.Add(400, "CD");
            baseNumbers.Add(500, "D");
            baseNumbers.Add(900, "CM");
            baseNumbers.Add(1000, "M");
        }

        public string GetRomanValueFromArabicNum(int number)
        {
            if (number < 1 || number >= MaxNumber)
            {
                throw new ArgumentOutOfRangeException($"{number} must be a positive integer of value less than {MaxNumber}");
            }

            throw new NotImplementedException();
        }

        public int GetArabicFromRoman(string romanNumeral)
        {
            throw new NotImplementedException();
        }
    }
}

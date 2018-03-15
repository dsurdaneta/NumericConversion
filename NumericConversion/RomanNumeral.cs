using System;
using System.Collections.Generic;
using System.Linq;

namespace DsuDev.NumericConversion
{
	/// <summary>
	/// Class to handle conversions between RomanNumeral and Arabic numbers.
	/// </summary>
    public class RomanNumeral
    {
        protected readonly Dictionary<int, string> baseNumbers;
        protected const int MaxNumber = 4000;
		private static string _error;
		public string ValidationMessage => _error;

		public RomanNumeral()
        {
			_error = "";

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
				_error = $"{number} must be a positive integer of value less than {MaxNumber}";
				throw new ArgumentOutOfRangeException(ValidationMessage);
            }

            string value = "";
            int current = number, i = 0;
            var keys = baseNumbers.AsEnumerable().Reverse().ToArray();

            while (current > 0)
            {
                var item = keys[i];
                if (current < item.Key)
                {
                    i++;
                    continue;
                }
                current -= item.Key;
                value += item.Value;
            }
            return value;
        }

        public int GetArabicFromRoman(string romanNumeral)
        {
			if (string.IsNullOrEmpty(romanNumeral))
			{
				_error = $"{nameof(romanNumeral)} should not be null nor empty";
				throw new ArgumentNullException(ValidationMessage);
			}

            var notAllowedValues = romanNumeral.Where(x => !baseNumbers.ContainsValue(x.ToString())).ToList();
			if (notAllowedValues.Count > 0)
			{
				_error = $"{romanNumeral} contains not allowed characters, such as {notAllowedValues.FirstOrDefault().ToString()}";
				throw new KeyNotFoundException(ValidationMessage);
			}

			int total = 0, lastValue = 0;
			for (int i = romanNumeral.Length - 1; i >= 0; i--)
			{
				string currentNumeral = romanNumeral[i].ToString();
				int currentValue = baseNumbers.First(x => x.Value == currentNumeral).Key;

				if (currentValue < lastValue)
					total -= currentValue;
				else
				{
					total += currentValue;
					lastValue = currentValue;
				}
			}
			return total;
        }

		public List<string> RangeRomanList(int start, int count)
		{
			List<string> romancollection = new List<string>();

			for(int i = 0; i < count; i++)
			{
				romancollection.Add(GetRomanValueFromArabicNum(start + i));
			}

			return romancollection;
		}
    }
}

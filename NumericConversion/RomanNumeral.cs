using System;
using System.Collections.Generic;
using System.Linq;
using DsuDev.NumericConversion.Constants;

namespace DsuDev.NumericConversion
{
	/// <summary>
	/// Class to handle conversions between RomanNumeral and Arabic numbers.
	/// </summary>
	public class RomanNumeral 
	{
		protected readonly Dictionary<int, string> BaseNumbers;        
		protected static string Error;
		public string ValidationMessage => Error;

		public RomanNumeral()
		{
			Error = "";
			BaseNumbers = new Dictionary<int, string>
			{
				{1, "I"},
				{4, "IV"},
				{5, "V"},
				{9, "IX"},
				{10, "X"},
				{40, "XL"},
				{50, "L"},
				{90, "XC"},
				{100, "C"},
				{400, "CD"},
				{500, "D"},
				{900, "CM"},
				{1000, "M"}
			};
		}

		public string GetRomanValueFromArabicNum(int number)
		{
			if (number < 1 || number >= Roman.MaxNumber)
			{
				Error = $"{number} must be a positive integer of value less than {Roman.MaxNumber}";
				throw new ArgumentOutOfRangeException(ValidationMessage);
			}

			string value = "";
			int current = number, i = 0;
			var keys = BaseNumbers.AsEnumerable().Reverse().ToArray();

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
				Error = $"{nameof(romanNumeral)} should not be null nor empty";
				throw new ArgumentNullException(ValidationMessage);
			}

			int total = 0, lastValue = 0;
			if (!IsRomanNumeralAllowed(romanNumeral)) return total;

			for (int i = romanNumeral.Length - 1; i >= 0; i--)
			{
				string currentNumeral = romanNumeral[i].ToString();
				int currentValue = BaseNumbers.First(x => x.Value == currentNumeral).Key;

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

		private bool IsRomanNumeralAllowed(string romanNumeral)
		{
			var notAllowedValues = romanNumeral.Where(x => !BaseNumbers.ContainsValue(x.ToString())).ToList();

			if (notAllowedValues.Count > 0)
			{
				Error = $"{romanNumeral} contains not allowed characters, such as {notAllowedValues.FirstOrDefault().ToString()}";
				throw new KeyNotFoundException(ValidationMessage);
			}

			return true;
		}

		public List<string> RangeRomanList(int start, int count)
		{
			List<string> romanNumeralCollection = new List<string>();

			for(int i = 0; i < count; i++)
			{
				romanNumeralCollection.Add(GetRomanValueFromArabicNum(start + i));
			}

			return romanNumeralCollection;
		}
	}
}

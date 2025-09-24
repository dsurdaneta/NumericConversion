using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DsuDev.NumericConversion
{
	public class DigitName
	{
	    private const string NotTranslatedError = "Digit could not be translated.";
		protected readonly Dictionary<int, string> DigitsWords;

		public DigitName()
		{
			DigitsWords = new Dictionary<int, string>
			{
				{0, "Zero" },
				{1, "One" },
				{2, "Two" },
				{3, "Three" },
				{4, "Four" },
				{5, "Five" },
				{6, "Six" },
				{7, "Seven" },
				{8, "Eight" },
				{9, "Nine" }
			};
		}

		public string Translate(int digitNumber)
		{
			if (digitNumber < 0 || digitNumber > 9)
				return string.Empty;

			return this.DigitsWords.First(x => x.Key == digitNumber).Value;
		}

		public int Translate(string digitWord)
		{
			var digitPair = this.DigitsWords.FirstOrDefault(
                x => string.Equals(x.Value.ToLower(), digitWord.ToLower(), StringComparison.Ordinal)
                );

			if (digitPair.Key >= 0 && !string.IsNullOrWhiteSpace(digitPair.Value))
				return digitPair.Key;

			throw new InvalidCastException(NotTranslatedError);
		}

		public string TranslateSeveralDigits(int fullNumber)
		{
			StringBuilder builder = new StringBuilder();
			string numberString = fullNumber.ToString();

			foreach (var item in numberString)
			{
				int digit = Convert.ToInt32(item.ToString());
				builder.Append(Translate(digit));
			}

			return builder.ToString();
		}

		public List<string> GetDigitNameList(int fullNumber)
		{
			List<string> digitNames = new List<string>();
			string numberString = fullNumber.ToString();

			foreach (var item in numberString)
			{
				int digit = Convert.ToInt32(item.ToString());
				digitNames.Add(Translate(digit));
			}

			return digitNames;
		}

		public int GetNumberFromDigitNameString(string digitNames)
		{
			List<string> nameList = new List<string>();
			string name = digitNames; 

			while (!string.IsNullOrWhiteSpace(name))
			{
				string digitName = this.DigitsWords.First(x => name.StartsWith(x.Value)).Value;
				nameList.Add(digitName);
				name = name.Remove(0, digitName.Length);
			}

			return this.GetNumberFromDigitNameList(nameList);
		}

		public int GetNumberFromDigitNameList(List<string> digitNameList)
		{
			string fullNumber = string.Empty;

			foreach (var item in digitNameList)
			{
				fullNumber += this.Translate(item);
			}

			return Convert.ToInt32(fullNumber);
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DsuDev.NumericConversion
{
	public class DigitName
	{
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

			return DigitsWords.First(x => x.Key == digitNumber).Value;
		}

		public int Translate(string digitWord)
		{
			var digitPair = DigitsWords.First(x => string.Equals(x.Value.ToLower(), digitWord.ToLower(), StringComparison.Ordinal));

			if (digitPair.Key > 0 && !string.IsNullOrEmpty(digitPair.Value))
				return digitPair.Key;

			throw new InvalidCastException("Digit could not be translated.");
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
	}
}

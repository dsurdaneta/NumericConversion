using System;
using System.Collections.Generic;
using System.Linq;

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
				return "";

			return DigitsWords.First(x => x.Key == digitNumber).Value;
		}

		public int Translate(string digitWord)
		{
			var digitPair = DigitsWords.First(x => string.Equals(x.Value.ToLower(), digitWord.ToLower(), StringComparison.Ordinal));

			if (digitPair.Key > 0 && !string.IsNullOrEmpty(digitPair.Value))
				return digitPair.Key;

			throw new InvalidCastException("Digit could not be translated.");
		}
	}
}

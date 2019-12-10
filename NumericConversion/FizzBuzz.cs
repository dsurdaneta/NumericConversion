using System;
using System.Collections.Generic;
using System.Linq;
using DsuDev.NumericConversion.Constants;

namespace DsuDev.NumericConversion
{
	/// <summary>
	/// Every multiple of 3 = Fizz.
	/// Every multiple of 5 = Buzz.
	/// Every multiple of 7 = Whizz.
	/// </summary>
	public class FizzBuzz 
	{
		private readonly Dictionary<int, string> _wordzzDictionary;

		public FizzBuzz()
		{
			_wordzzDictionary = new Dictionary<int, string>
			{
				{ 3, Wordzz.Fizz },
				{ 5, Wordzz.Buzz },
				{ 7, Wordzz.Whizz }
			};
		}

		public string GetFizzBuzz(int number)
		{
			string result = this.TranslateToWords(number);

			if (string.IsNullOrEmpty(result))
				result = number.ToString();

			return result;
		}

		internal string TranslateToWords(int number)
		{
			if (number == 0)
				return number.ToString();

			string result = "";						

			foreach (KeyValuePair<int, string> item in this._wordzzDictionary)
			{
				if (number % item.Key == 0)
					result += item.Value;
			}
			return result;
		}

		/// <summary>
		/// Gets the number related to the FizzBuzz words configuration
		/// </summary>
		/// <param name="word"></param>
		/// <returns></returns>
		public int GetNumberFromFizzBuzz(string word)
		{
			if (string.IsNullOrEmpty(word))
				throw new ArgumentNullException();

			return this._wordzzDictionary.First(x => x.Value.ToLower() == word.ToLower()).Key;
		}
		
		/// <summary>
		/// Generates a list of FizzBuzzWhizz numbers
		/// </summary>
		/// <param name="number">The last number of the list</param>
		/// <param name="includeZero">true to start at 0, false to start at 1. Default value is false</param>
		/// <returns></returns>
		public List<string> GenerateFizzBuzzList(int number, bool includeZero = false)
		{
			if (number < 0)
				return this.GenerateNegativeFizzBuzzList(number, includeZero);
				
			List<string> words = new List<string>();
			if (includeZero)
				words.Add("0");			

			for (int i = 0; i < number; i++)
				words.Add(this.GetFizzBuzz(i + 1));

			return words;
		}

		/// <summary>
		/// Generates a negative list of FizzBuzzWhizz numbers
		/// </summary>
		/// <param name="number">the first negative number</param>
		/// <param name="includeZero">true to end at 0, false to end at 1. Default value is false</param>
		/// <param name="reverse">indicates if the list must be reversed. Default true</param>
		/// <returns></returns>
		public List<string> GenerateNegativeFizzBuzzList(int number, bool includeZero = false, bool reverse = true)
		{			
			if (number > 0)
				return this.GenerateFizzBuzzList(number, includeZero);
						
			List<string> words = new List<string>();
			for (int i = number; i < 0; i++)
				words.Add(this.GetFizzBuzz(i));

			if (includeZero)
				words.Add("0");			
			if (reverse)
				words.Reverse();

			return words;
		}
	}
}

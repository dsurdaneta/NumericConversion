using System;
using System.Collections.Generic;

namespace DsuDev.NumericConversion
{
    public class FizzBuzz
    {
        public const string Fizz = "Fizz";
        public const string Buzz = "Buzz";
        public const string Whizz = "Whizz";

        private readonly Dictionary<int, string> wordzzDictionary;

        public FizzBuzz()
        {
            wordzzDictionary = new Dictionary<int, string>
            {
                { 3, Fizz },
                { 5, Buzz },
                { 7, Whizz }
            };
        }

        public string GetFizzBuzz(int number)
        {
            string result = TranslateToWords(number);

            if (string.IsNullOrEmpty(result))
                result = number.ToString();

            return result;
        }

        internal string TranslateToWords(int number)
        {
            string result = "";

            foreach (KeyValuePair<int, string> item in wordzzDictionary)
            {
                if (number % item.Key == 0)
                    result += item.Value;
            }

            return result;
        }

    }
}

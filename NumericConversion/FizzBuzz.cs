using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DsuDev.NumericConversion
{
    public class FizzBuzz
    {
        public const string Fizz = "Fizz";
        public const string Buzz = "Buzz";
        public const string Whizz = "Whizz";

        public string GetFizzBuzz(int number)
        {
            string result = number.ToString();
            if (number % 3 == 0)
            {
                result = Fizz;
            }

            return result;
        }
    }
}

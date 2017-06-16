﻿using System;
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
            string result = "";

            if (number % 3 == 0)
            {
                result += Fizz;
            }

            if (number % 5 == 0)
            {
                result += Buzz;
            }

            if (result == "")
            {
                result = number.ToString();
            }

            return result;
        }
    }
}
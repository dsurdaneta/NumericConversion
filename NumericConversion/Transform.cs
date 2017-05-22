using System;
using System.Text;

namespace NumericConversion
{
    public class Transform
    {
        protected static string _error;
        internal const string L = "1000000";

        public string ValidationMessage
        {
            get { return _error; }
        }

        public Transform()
        {
            _error = "";
        }

        public static long IntegerToBinaryLong(int number)
        {
            long n = -1;
            string s = Convert.ToString(number, 2);
            if(s.Length <= L.Length)
                n = Convert.ToInt64(s);
            else
                _error = "number " + number + " length not supported";

            return n;
        }

        public static string IntegerToBinaryString(int number)
        {
            return IntegerToBinaryLong(number).ToString();
        }

        public static long IntegerToOctalLong(int number)
        {
            long n = -1;
            string s = Convert.ToString(number, 2);
            if (s.Length <= L.Length)
                n = Convert.ToInt64(Convert.ToString(number, 8));
            else
                _error = "number " + number + " length not supported";

            return n;
        }

        public static string IntegerToHexString(int number)
        {
            //return Convert.ToString(number, 16).ToUpper();
            //ToString("X") already transform to hex
            return number.ToString("X");
        }
    }
}

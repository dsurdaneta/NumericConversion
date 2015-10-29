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

        public static long ToBinaryNumber(int number)
        {
            long n = -1;
            string s = Convert.ToString(number, 2);
            if(s.Length <= L.Length)
                n = Convert.ToInt64(s);
            return n;
        }

        public static long ToOctalNumber(int number)
        {
            long n = -1;
            string s = Convert.ToString(number, 2);
            if (s.Length <= L.Length)
                n = Convert.ToInt64(Convert.ToString(number, 8));
            return n;
        }

        public static string ToHex(int number)
        {
            return Convert.ToString(number, 16).ToUpper();
        }
    }
}

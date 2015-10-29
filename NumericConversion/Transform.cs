using System;
using System.Text;

namespace NumericConversion
{
    public class Transform
    {
        protected static string _error;

        public string ValidationMessage
        {
            get { return _error; }
        }

        public Transform()
        {
            _error = "";
        }

        public static int ToBinaryNumber(int number)
        {
            return Convert.ToInt32(Convert.ToString(number, 2));;
        }

        public static int ToOctalNumber(int number)
        {
            return Convert.ToInt32(Convert.ToString(number, 8));
        }

        public static string ToHex(int number)
        {
            return Convert.ToString(number, 16).ToUpper();
        }
    }
}

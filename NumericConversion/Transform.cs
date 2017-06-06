using System;
using System.Text;

namespace DsuDev.NumericConversion
{
    public class Transform
    {
        protected static string _error;
        internal const string BinaryStringMaxLength = "1000000";
        internal const string HexPrefix = "0x";

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
            long binaryLong = -1;
            string binaryString = Convert.ToString(number, 2);
            if (binaryString.Length <= BinaryStringMaxLength.Length)
                binaryLong = Convert.ToInt64(binaryString);
            else
            {
                _error = $"number {number} length not supported, it has to be less than {BinaryStringMaxLength.Length} digits";
                //_error = "number " + number + " length not supported";
                throw new ArgumentOutOfRangeException(nameof(number), number, _error);
            }

            return binaryLong;
        }

        public static string IntegerToBinaryString(int number)
        {
            return Convert.ToString(number, 2); 
        }

        public static long IntegerToOctalLong(int number)
        {
            long octalLong = -1;
            string binaryString = Convert.ToString(number, 2);
            if (binaryString.Length <= BinaryStringMaxLength.Length)
                octalLong = Convert.ToInt64(Convert.ToString(number, 8));
            else
                _error = $"number {number} length not supported";
                 //_error = "number " + number + " length not supported";

            return octalLong;
        }

        public static string IntegerToOctalString(int number)
        {
            return Convert.ToString(number, 8);
        }

        /// <summary>
        /// As most hex literals are handled with the 0x prefix, you can choose if you want 
        /// the result string formatted with or without the prefix
        /// </summary>
        /// <param name="number"></param>
        /// <param name="prefixed"></param>
        /// <returns></returns>
        public static string IntegerToHexString(int number, bool prefixed = true)
        {
            string hexNumber = prefixed ? HexPrefix : "";

            //return Convert.ToString(number, 16).ToUpper();
            //ToString("X") already transform to hex
            hexNumber = hexNumber + number.ToString("X").ToUpper();

            return hexNumber;
        }

        public static int BinaryLongToInt(long binaryNumber)
        {
            int binaryInt = -1;
            string binaryString = Convert.ToString(binaryNumber);
            binaryInt = Convert.ToInt32(binaryString, 2);
            return binaryInt;
        }

        public static int BinaryStringToInt(string binaryNumber)
        {
            return Convert.ToInt32(binaryNumber, 2);
        }

        public static int OctalStringToInt(string octalNumber)
        {
            return Convert.ToInt32(octalNumber, 8);
        }

        public static int HexStringToInt(string hexNumber)
        {
            int resultValue = 0;

            if (hexNumber.StartsWith(HexPrefix))
            {
                resultValue = Convert.ToInt32(hexNumber, 16);
            }
            else
            {
                resultValue = int.Parse(hexNumber, System.Globalization.NumberStyles.HexNumber);
            }

            return resultValue;
        }
    }
}

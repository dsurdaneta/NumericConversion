using System;
using System.Text;

namespace DsuDev.NumericConversion
{
    public class Transform
    {
        public const int BinaryStringMaxLength = 19;
        internal const string HexPrefix = "0x";
        protected static string _error;
        public string ValidationMessage => _error;

        public Transform() { _error = ""; }

        public static long IntegerToBinaryLong(int number)
        {
			if (number < 0)
				ThrowNegativeBinaryStringUnsupported(number);

            long binaryLong = -1;
            string binaryString = Convert.ToString(number, 2);

            if (binaryString.Length <= BinaryStringMaxLength)
                binaryLong = Convert.ToInt64(binaryString);
            else
				ThrowBinaryOutOfRangeException(number, binaryString);

            return binaryLong;
        }

        public static string IntegerToBinaryString(int number)
        {
            return Convert.ToString(number, 2); 
        }

        public static long IntegerToOctalLong(int number)
        {
			if (number < 0)
				ThrowNegativeBinaryStringUnsupported(number);

			long octalLong = -1;
            string binaryString = Convert.ToString(number, 2);

            if (binaryString.Length <= BinaryStringMaxLength)
                octalLong = Convert.ToInt64(Convert.ToString(number, 8));
            else
				ThrowBinaryOutOfRangeException(number, binaryString);

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
            hexNumber = hexNumber + number.ToString("X").ToUpper();
            return hexNumber;
        }

        public static int BinaryLongToInt(long binaryNumber)
        {
			string binaryString = Convert.ToString(binaryNumber);
            return Convert.ToInt32(binaryString, 2);
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
                resultValue = Convert.ToInt32(hexNumber, 16);
            else
                resultValue = int.Parse(hexNumber, System.Globalization.NumberStyles.HexNumber);

            return resultValue;
        }
		
		public static bool IsNumeric(string value)
		{
			return double.TryParse(value, out double result);
		}

		#region Exception handling
		internal static void ThrowBinaryOutOfRangeException(int number, string binaryConvertedString)
		{
			_error = $"number ({number}) length not supported, it has to be less than {BinaryStringMaxLength} digits, current binary length {binaryConvertedString.Length}";
			throw new ArgumentOutOfRangeException(nameof(number), number, _error);
		}

		internal static void ThrowNegativeBinaryStringUnsupported(int number)
		{
			_error = $"Negative numbers casting ({number}) is not supported for this method";
			throw new InvalidCastException(_error);
		}
		#endregion
	}
}

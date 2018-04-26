using System;
using DsuDev.NumericConversion.Constants;

namespace DsuDev.NumericConversion
{
	/// <summary>
	/// Class to handle conversions between several numeric bases, including:
	/// -Decimal
	/// -Binary
	/// -Octal
	/// -Hex
	/// </summary>
	public class Transform
	{                
		protected static string _error;
		public string ValidationMessage => _error;

		public Transform() { _error = ""; }

		public static long IntegerToBinaryLong(int number)
		{
			if (number < 0)
				ThrowNegativeBinaryStringUnsupported(number);

			long binaryLong = -1;
			string binaryString = Convert.ToString(number, NumberBase.BinaryBase);

			if (binaryString.Length < NumberBase.BinaryStringMaxLength)
				binaryLong = Convert.ToInt64(binaryString);
			else
				ThrowBinaryOutOfRangeException(number, binaryString);

			return binaryLong;
		}

		public static string IntegerToBinaryString(int number)
		{
			return Convert.ToString(number, NumberBase.BinaryBase); 
		}

		public static long IntegerToOctalLong(int number)
		{
			if (number < 0)
				ThrowNegativeBinaryStringUnsupported(number);

			long octalLong = -1;
			string binaryString = Convert.ToString(number, NumberBase.BinaryBase);

			if (binaryString.Length < NumberBase.BinaryStringMaxLength)
				octalLong = Convert.ToInt64(Convert.ToString(number, NumberBase.OctalBase));
			else
				ThrowBinaryOutOfRangeException(number, binaryString);

			return octalLong;
		}

		public static string IntegerToOctalString(int number)
		{
			return Convert.ToString(number, NumberBase.OctalBase);
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
			string hexNumber = prefixed ? NumberBase.HexPrefix : "";
			hexNumber = hexNumber + number.ToString("X").ToUpper();
			return hexNumber;
		}

		public static int BinaryLongToDecimalInt(long binaryNumber)
		{
			string binaryString = Convert.ToString(binaryNumber);
			return Convert.ToInt32(binaryString, NumberBase.BinaryBase);
		}

		public static int BinaryStringToInt(string binaryNumber)
		{
			return Convert.ToInt32(binaryNumber, NumberBase.BinaryBase);
		}

		public static int OctalStringToInt(string octalNumber)
		{
			return Convert.ToInt32(octalNumber, NumberBase.OctalBase);
		}

		public static int HexStringToInt(string hexNumber)
		{
			if (hexNumber.StartsWith(NumberBase.HexPrefix))
				return Convert.ToInt32(hexNumber, NumberBase.HexBase);

			return int.Parse(hexNumber, System.Globalization.NumberStyles.HexNumber);
		}
		
		public static bool IsNumeric(string value)
		{
			return double.TryParse(value, out double result);
		}

		#region Exception handling
		internal static void ThrowBinaryOutOfRangeException(int number, string binaryConvertedString)
		{
			_error = $"number ({number}) length not supported, it has to be less than {NumberBase.BinaryStringMaxLength} digits, current binary length {binaryConvertedString.Length}";
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

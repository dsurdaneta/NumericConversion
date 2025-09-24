using System.Runtime.CompilerServices;

[assembly:InternalsVisibleTo("DsuDev.NumericConversion.Test")]
namespace DsuDev.NumericConversion.Constants
{
	public class NumberBase
	{
		internal const string HexPrefix = "0x";
		internal const int BinaryBase = 2;
		internal const int OctalBase = 8;
		internal const int DecimalBase = 10;
		internal const int HexBase = 16;

		public const int BinaryStringMaxLength = 20;
	}
}

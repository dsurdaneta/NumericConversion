using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DsuDev.NumericConversion.Test.Convert
{
	[TestClass]
	public class TransformTests
	{
		[TestMethod]
		public void Transform_IsNotNull()
		{
			//Act
			var result = new Transform();
			//Assert
			Assert.IsNotNull(result);
		}

		[TestMethod]
		public void Transform_ValidationMessageisNotNull()
		{
			//Act
			var result = new Transform();
			//Assert
			Assert.IsNotNull(result.ValidationMessage);
		}

		[TestMethod]
		public void Transform_NotANumber()
		{
			//Act
			var result = Transform.IsNumeric("Hello");
			//Assert
			Assert.IsFalse(result);
		}

		[TestMethod]
		public void Transform_IsNumeric()
		{
			//Act
			var result = Transform.IsNumeric("1");
			//Assert
			Assert.IsTrue(result);
		}

		[TestMethod]
		public void Transform_IntToBinaryLongTest()
		{
			//Act
			long baseTwo = Transform.IntegerToBinaryLong(3);
			//Assert
			Assert.AreEqual(baseTwo, 11);
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentOutOfRangeException))]
		public void Transform_IntToBinaryLongTooLongExceptionTest()
		{
			Transform.IntegerToBinaryLong(2132132135);
		}

		[TestMethod]
		public void Transform_IntToOctalLongTest()
		{
			//Act
			var baseEight = Transform.IntegerToOctalLong(8);
			//Assert
			Assert.AreEqual(10, baseEight);
		}

		[TestMethod]
		public void Transform_IntToOctalStringTest()
		{
			//Act
			var baseEight = Transform.IntegerToOctalString(9);
			//Assert
			Assert.AreEqual("11", baseEight);
		}
				
		[TestMethod]
		public void Transform_HexStringWithOutPrefixTest()
		{
			//Act
			var hexString = Transform.IntegerToHexString(27, false);
			//Assert
			Assert.IsFalse(hexString.StartsWith("0x"));
			Assert.AreEqual("1B", hexString);
		}

		[TestMethod]
		public void Transform_HexPrefixTest()
		{
			//Act
			var hexString = Transform.IntegerToHexString(28, true);
			//Assert
			Assert.IsTrue(hexString.StartsWith("0x"));
			Assert.AreEqual("0x1C", hexString);
		}

		[TestMethod]
		public void Transform_IntToBinaryStringTest()
		{
			//Act
			var baseTwo = Transform.IntegerToBinaryString(5);
			//Assert
			Assert.AreEqual("101", baseTwo);
		}

		[TestMethod]
		public void Transform_NegativeIntToBinaryStringTest()
		{
			//Act
			var baseTwo = Transform.IntegerToBinaryString(-5);
			//Assert
			Assert.AreEqual("11111111111111111111111111111011", baseTwo);
		}

		[TestMethod]
		[ExpectedException(typeof(InvalidCastException))]
		public void Transform_NegativeIntToBinaryLongUnsupported_Test()
		{
			long baseTwo = Transform.IntegerToBinaryLong(-1);
		}

		[TestMethod]
		[ExpectedException(typeof(InvalidCastException))]
		public void Transform_NegativeIntToOctalLongUnsupported_Test()
		{
			long baseEight = Transform.IntegerToOctalLong(-1);
		}

		[TestMethod]
		public void Transform_NegativeHexStringWithOutPrefixTest()
		{
			//Act
			var hexString = Transform.IntegerToHexString(-27, false);
			//Assert
			Assert.IsFalse(hexString.StartsWith("0x"));
			Assert.AreEqual("FFFFFFE5", hexString);
		}

		[TestMethod]
		public void Transform_NegativeHexPrefixTest()
		{
			//Act
			var hexString = Transform.IntegerToHexString(-28, true);
			//Assert
			Assert.IsTrue(hexString.StartsWith("0x"));
			Assert.AreEqual("0xFFFFFFE4", hexString);
		}

		[TestMethod]
		public void Transform_NegativeIntToOctalStringTest()
		{
			//Act
			var baseEight = Transform.IntegerToOctalString(-9);
			//Assert
			Assert.AreEqual("37777777767", baseEight);
		}

		[TestMethod]
		public void Transform_HexStringToInt()
		{
			//Act
			var sut = Transform.HexStringToInt("3AF");
			//Assert
			Assert.AreEqual(943, sut);
		}

		[TestMethod]
		public void Transform_HexStringToIntWithPrefix()
		{
			//Act
			var sut = Transform.HexStringToInt("0x3AF");
			//Assert
			Assert.AreEqual(943, sut);
		}

		[TestMethod]
		public void Transform_OctalStringToInt()
		{
			//Act
			var sut = Transform.OctalStringToInt("14");
			//Assert
			Assert.AreEqual(12, sut);
		}

		[TestMethod]
		public void Transform_BinaryStringToInt()
		{
			//Act
			var sut = Transform.BinaryStringToInt("1001");
			//Assert
			Assert.AreEqual(9, sut);
		}

		[TestMethod]
		public void Transform_BinaryLongToInt()
		{
			//Arrange
			long binaryNumber = 11111110111000111;
			//Act
			var sut = Transform.BinaryLongToDecimalInt(binaryNumber);
			//Assert
			Assert.AreEqual(130503, sut);
		}
	}
}

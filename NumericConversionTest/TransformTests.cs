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
			var sut = new Transform();
			//Assert
			Assert.IsNotNull(sut);
		}

		[TestMethod]
		public void Transform_ValidationMessageisNotNull()
		{
			//Act
			var sut = new Transform();
			//Assert
			Assert.IsNotNull(sut.ValidationMessage);
		}

		[TestMethod]
		public void Transform_NotANumber()
		{
			//Act
			var sut = Transform.IsNumeric("Hello");
			//Assert
			Assert.IsFalse(sut);
		}

		[TestMethod]
		public void Transform_IsNumeric()
		{
			//Act
			var sut = Transform.IsNumeric("1");
			//Assert
			Assert.IsTrue(sut);
		}

		[TestMethod]
		public void Transform_IntToBinaryLongTest()
		{
			//Act
			long sut = Transform.IntegerToBinaryLong(3);
			//Assert
			Assert.AreEqual(11, sut);
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
			var sut = Transform.IntegerToOctalLong(8);
			//Assert
			Assert.AreEqual(10, sut);
		}

		[TestMethod]
		public void Transform_IntToOctalStringTest()
		{
			//Act
			var sut = Transform.IntegerToOctalString(9);
			//Assert
			Assert.AreEqual("11", sut);
		}
				
		[TestMethod]
		public void Transform_HexStringWithOutPrefixTest()
		{
			//Act
			var sut = Transform.IntegerToHexString(27, false);
			//Assert
			Assert.IsFalse(sut.StartsWith("0x"));
			Assert.AreEqual("1B", sut);
		}

		[TestMethod]
		public void Transform_HexPrefixTest()
		{
			//Act
			var sut = Transform.IntegerToHexString(28, true);
			//Assert
			Assert.IsTrue(sut.StartsWith("0x"));
			Assert.AreEqual("0x1C", sut);
		}

		[TestMethod]
		public void Transform_IntToBinaryStringTest()
		{
			//Act
			var sut = Transform.IntegerToBinaryString(5);
			//Assert
			Assert.AreEqual("101", sut);
		}

		[TestMethod]
		public void Transform_NegativeIntToBinaryStringTest()
		{
			//Act
			var sut = Transform.IntegerToBinaryString(-5);
			//Assert
			Assert.AreEqual("11111111111111111111111111111011", sut);
		}

		[TestMethod]
		[ExpectedException(typeof(InvalidCastException))]
		public void Transform_NegativeIntToBinaryLongUnsupported_Test()
		{
			Transform.IntegerToBinaryLong(-1);
		}

		[TestMethod]
		[ExpectedException(typeof(InvalidCastException))]
		public void Transform_NegativeIntToOctalLongUnsupported_Test()
		{
			Transform.IntegerToOctalLong(-1);
		}

		[TestMethod]
		public void Transform_NegativeHexStringWithOutPrefixTest()
		{
			//Act
			var sut = Transform.IntegerToHexString(-27, false);
			//Assert
			Assert.IsFalse(sut.StartsWith("0x"));
			Assert.AreEqual("FFFFFFE5", sut);
		}

		[TestMethod]
		public void Transform_NegativeHexPrefixTest()
		{
			//Act
			var sut = Transform.IntegerToHexString(-28, true);
			//Assert
			Assert.IsTrue(sut.StartsWith("0x"));
			Assert.AreEqual("0xFFFFFFE4", sut);
		}

		[TestMethod]
		public void Transform_NegativeIntToOctalStringTest()
		{
			//Act
			var sut = Transform.IntegerToOctalString(-9);
			//Assert
			Assert.AreEqual("37777777767", sut);
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

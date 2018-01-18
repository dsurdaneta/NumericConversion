using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DsuDev.NumericConversion.Test.Convert
{
    [TestClass]
    public class TransformTest
    {
        [TestMethod]
        public void Transform_isNotNull()
        {
			//Act
            var result = new Transform();
			//Assert
            Assert.IsNotNull(result);
        }

		[TestMethod]
		public void Transform_notANumber()
		{
			//Act
			var result = Transform.IsNumeric("Hello");
			//Assert
			Assert.IsFalse(result);
		}

		[TestMethod]
		public void Transform_isNumeric()
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
            Assert.AreEqual(baseEight, 10);
        }

		[TestMethod]
		public void Transform_IntToOctalStringTest()
		{
			//Act
			var baseEight = Transform.IntegerToOctalString(9);
			//Assert
			Assert.AreEqual(baseEight, "11");
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
            Assert.AreEqual(baseTwo, "101");
        }

		[TestMethod]
		public void Transform_negativeIntToBinaryStringTest()
		{
			//Act
			var baseTwo = Transform.IntegerToBinaryString(-5);
			//Assert
			Assert.AreEqual(baseTwo, "11111111111111111111111111111011");
		}

		[TestMethod]
		[ExpectedException(typeof(InvalidCastException))]
		public void Transform_negativeIntToBinaryLongUnsupported_Test()
		{
			long baseTwo = Transform.IntegerToBinaryLong(-1);
		}

		[TestMethod]
		[ExpectedException(typeof(InvalidCastException))]
		public void Transform_negativeIntToOctalLongUnsupported_Test()
		{
			long baseEight = Transform.IntegerToOctalLong(-1);
		}

		[TestMethod]
		public void Transform_negativeHexStringWithOutPrefixTest()
		{
			//Act
			var hexString = Transform.IntegerToHexString(-27, false);
			//Assert
			Assert.IsFalse(hexString.StartsWith("0x"));
			Assert.AreEqual("FFFFFFE5", hexString);
		}

		[TestMethod]
		public void Transform_negativeHexPrefixTest()
		{
			//Act
			var hexString = Transform.IntegerToHexString(-28, true);
			//Assert
			Assert.IsTrue(hexString.StartsWith("0x"));
			Assert.AreEqual("0xFFFFFFE4", hexString);
		}

		[TestMethod]
		public void Transform_negativeIntToOctalStringTest()
		{
			//Act
			var baseEight = Transform.IntegerToOctalString(-9);
			//Assert
			Assert.AreEqual(baseEight, "37777777767");
		}
	}
}

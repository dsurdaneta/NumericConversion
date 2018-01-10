using System;
using DsuDev.NumericConversion;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NumericConversion.Test
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
            long baseEight = Transform.IntegerToOctalLong(8);
			//Assert
            Assert.AreEqual(baseEight, 10);
        }

        [TestMethod]
        public void Transform_HexStringTypeTest()
        {
			//Act
            var hexString = Transform.IntegerToHexString(25);
			//Assert
            Assert.IsInstanceOfType(hexString, typeof(string));
        }

        [TestMethod]
        public void Transform_HexStringWithOutPrefixTest()
        {
			//Act
            var hexString = Transform.IntegerToHexString(27, false);
			//Assert
            Assert.IsFalse(hexString.StartsWith("0x"));
        }

        [TestMethod]
        public void Transform_HexPrefixTest()
        {
			//Act
            var hexString = Transform.IntegerToHexString(28, true);
			//Assert
            Assert.IsTrue(hexString.StartsWith("0x"));
        }

        [TestMethod]
        public void Transform_IntToBinaryStringTest()
        {
			//Act
            var baseTwo = Transform.IntegerToBinaryString(5);
			//Assert
            Assert.AreEqual(baseTwo, "101");
        }
    }
}

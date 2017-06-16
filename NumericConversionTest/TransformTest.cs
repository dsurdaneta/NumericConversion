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
            var result = new Transform();

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Transform_IntToBinaryLongTest()
        {
            long baseTwo = Transform.IntegerToBinaryLong(3);
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
            long baseEight = Transform.IntegerToOctalLong(8);
            Assert.AreEqual(baseEight, 10);
        }

        [TestMethod]
        public void Transform_HexStringTypeTest()
        {
            var hexString = Transform.IntegerToHexString(25);
            Assert.IsInstanceOfType(hexString, typeof(string));
        }

        [TestMethod]
        public void Transform_HexStringWithOutPrefixTest()
        {
            var hexString = Transform.IntegerToHexString(27, false);
            Assert.IsFalse(hexString.StartsWith("0x"));
        }

        [TestMethod]
        public void Transform_HexPrefixTest()
        {
            var hexString = Transform.IntegerToHexString(28, true);
            Assert.IsTrue(hexString.StartsWith("0x"));
        }

        [TestMethod]
        public void Transform_IntToBinaryStringTest()
        {
            var baseTwo = Transform.IntegerToBinaryString(5);
            Assert.AreEqual(baseTwo, "101");
        }
    }
}

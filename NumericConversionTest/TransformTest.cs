using System;
using DsuDev.NumericConversion;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NumericConversion.Test
{
    [TestClass]
    public class TransformTest
    {
        [TestMethod]
        public void IntToBinaryLongTest()
        {
            long baseTwo = Transform.IntegerToBinaryLong(3);
            Assert.AreEqual(baseTwo, 11);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void IntToBinaryLongTooLongExceptionTest()
        {
            Transform.IntegerToBinaryLong(2132132135);
        }

        [TestMethod]
        public void IntToOctalLongTest()
        {
            long baseEight = Transform.IntegerToOctalLong(8);
            Assert.AreEqual(baseEight, 10);
        }

        [TestMethod]
        public void HexStringTypeTest()
        {
            var hexString = Transform.IntegerToHexString(25);
            Assert.IsInstanceOfType(hexString, typeof(string));
        }

        [TestMethod]
        public void HexStringWithOutPrefixTest()
        {
            var hexString = Transform.IntegerToHexString(27, false);
            Assert.IsFalse(hexString.StartsWith("0x"));
        }

        [TestMethod]
        public void HexPrefixTest()
        {
            var hexString = Transform.IntegerToHexString(28, true);
            Assert.IsTrue(hexString.StartsWith("0x"));
        }

        [TestMethod]
        public void IntToBinaryStringTest()
        {
            var baseTwo = Transform.IntegerToBinaryString(5);
            Assert.AreEqual(baseTwo, "101");
        }
    }
}

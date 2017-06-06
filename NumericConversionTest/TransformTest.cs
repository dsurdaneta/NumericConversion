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
            Assert.AreEqual(baseTwo,11);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void IntToBinaryLongTooLongExceptionTest()
        {
            long baseTwo = Transform.IntegerToBinaryLong(10000003);
        }

        [TestMethod]
        public void IntToOctalLongTest()
        {
            long baseEight = Transform.IntegerToOctalLong(8);
            Assert.AreEqual(baseEight,10);
        }

        [TestMethod]
        public void HexStringTypeTest()
        {
            var hexString = Transform.IntegerToHexString(25);
            Assert.IsInstanceOfType(hexString,typeof(string));
        }

        [TestMethod]
        public void IntToBinaryStringTest()
        {
            var baseTwo = Transform.IntegerToBinaryString(5);
            Assert.AreEqual(baseTwo, "101");
        }
    }
}

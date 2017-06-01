﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumericConversion;

namespace NumericConversionTest
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
    }
}

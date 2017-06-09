using System;
using DsuDev.NumericConversion;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NumericConversion.Test
{
    [TestClass]
    public class RomanTest
    {
        [TestMethod]
        public void RomanNumeral_IsNotNull()
        {
            // Arrange
            var romanNumeral = new RomanNumeral();

            // Act
            // Assert
            Assert.IsNotNull(romanNumeral);
        }
         
        [TestMethod]
        public void RomanNumeral_IsString()
        {
            // Arrange
            var romanNumeral = new RomanNumeral();

            // Act
            // Assert
            Assert.IsInstanceOfType(romanNumeral.GetRomanValueFromArabicNum(10), typeof(string));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void RomanNumeral_MaxRange()
        {
            // Arrange
            var romanNumeral = new RomanNumeral();

            // Act
            romanNumeral.GetRomanValueFromArabicNum(5000);
            // Assert
        }

        [TestMethod]
        public void RomanNumeral_ArabicIsInt()
        {
            // Arrange
            var romanNumeral = new RomanNumeral();

            // Act
            // Assert
            Assert.IsInstanceOfType(romanNumeral.GetArabicFromRoman("DUX"), typeof(int));
        }
    }
}

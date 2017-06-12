using System;
using System.Linq;
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
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void RomanNumeral_MinRange()
        {
            // Arrange
            var romanNumeral = new RomanNumeral();

            // Act
            romanNumeral.GetRomanValueFromArabicNum(-7);
            // Assert
        }

        [TestMethod]
        public void RomanNumeral_1to3()
        {
            // Arrange
            var romanNumeral = new RomanNumeral();

            // Act
            var number1 = romanNumeral.GetRomanValueFromArabicNum(1);
            var number2 = romanNumeral.GetRomanValueFromArabicNum(2);
            var number3 = romanNumeral.GetRomanValueFromArabicNum(3);
            // Assert
            Assert.AreEqual("I", number1);
            Assert.AreEqual("II", number2);
            Assert.AreEqual("III", number3);
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

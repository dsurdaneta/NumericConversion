using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DsuDev.NumericConversion.Test.Roman
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
		public void RomanNumeral_4to8()
		{
			// Arrange
            var romanNumeral = new RomanNumeral();

            // Act
            var number4 = romanNumeral.GetRomanValueFromArabicNum(4);
            var number5 = romanNumeral.GetRomanValueFromArabicNum(5);
            var number6 = romanNumeral.GetRomanValueFromArabicNum(6);
			var number7 = romanNumeral.GetRomanValueFromArabicNum(7);
			var number8 = romanNumeral.GetRomanValueFromArabicNum(8);
			
			// Assert
			Assert.AreEqual("IV", number4);
            Assert.AreEqual("V", number5);
            Assert.AreEqual("VI", number6);
			Assert.AreEqual("VII", number7);
			Assert.AreEqual("VIII", number8);
		}

		[TestMethod]
		public void RomanNumeral_9to13()
		{
			// Arrange
			var romanNumeral = new RomanNumeral();

			// Act
			var number4 = romanNumeral.GetRomanValueFromArabicNum(9);
			var number5 = romanNumeral.GetRomanValueFromArabicNum(10);
			var number6 = romanNumeral.GetRomanValueFromArabicNum(11);
			var number7 = romanNumeral.GetRomanValueFromArabicNum(12);
			var number8 = romanNumeral.GetRomanValueFromArabicNum(13);

			// Assert
			Assert.AreEqual("IX", number4);
			Assert.AreEqual("X", number5);
			Assert.AreEqual("XI", number6);
			Assert.AreEqual("XII", number7);
			Assert.AreEqual("XIII", number8);
		}

		[TestMethod]
		public void RomanNumeral_3709()
		{
			// Arrange
			var romanNumeral = new RomanNumeral();
			// Act
			var number = romanNumeral.GetRomanValueFromArabicNum(3709);
			// Assert
			Assert.AreEqual(number, "MMMDCCIX");
		}

        [TestMethod]
		[ExpectedException(typeof(KeyNotFoundException))]
        public void RomanNumeral_ArabicKeyNotFound()
        {
            // Arrange
            var romanNumeral = new RomanNumeral();
			// Act
			romanNumeral.GetArabicFromRoman("DUX");
			// Assert
        }

		[TestMethod]
		[ExpectedException(typeof(ArgumentNullException))]
		public void RomanNumeral_ArabicNull()
		{
			// Arrange
			var romanNumeral = new RomanNumeral();
			// Act
			romanNumeral.GetArabicFromRoman(null);
			// Assert
		}

		[TestMethod]
		public void Roman2Arabic_1to3()
		{
			// Arrange
			var romanNumeral = new RomanNumeral();

			// Act
			var number1 = romanNumeral.GetArabicFromRoman("I");
			var number2 = romanNumeral.GetArabicFromRoman("II");
			var number3 = romanNumeral.GetArabicFromRoman("III");
			// Assert
			Assert.AreEqual(1, number1);
			Assert.AreEqual(2, number2);
			Assert.AreEqual(3, number3);
		}

		[TestMethod]
		public void Roman2Arabic_1427()
		{
			// Arrange
			var romanNumeral = new RomanNumeral();
			// Act
			var number = romanNumeral.GetArabicFromRoman("MCDXXVII");
			// Assert
			Assert.AreEqual(1427, number);
		}

		[TestMethod]
		public void Roman2Arabic_4to8()
		{
			// Arrange
			var romanNumeral = new RomanNumeral();

			// Act
			var number4 = romanNumeral.GetArabicFromRoman("IV");
			var number5 = romanNumeral.GetArabicFromRoman("V");
			var number6 = romanNumeral.GetArabicFromRoman("VI");
			var number7 = romanNumeral.GetArabicFromRoman("VII");
			var number8 = romanNumeral.GetArabicFromRoman("VIII");

			// Assert
			Assert.AreEqual(4, number4);
			Assert.AreEqual(5, number5);
			Assert.AreEqual(6, number6);
			Assert.AreEqual(7, number7);
			Assert.AreEqual(8, number8);
		}

		[TestMethod]
		public void Roman2Arabic_9to13()
		{
			// Arrange
			var romanNumeral = new RomanNumeral();

			// Act
			var number4 = romanNumeral.GetArabicFromRoman("IX");
			var number5 = romanNumeral.GetArabicFromRoman("X");
			var number6 = romanNumeral.GetArabicFromRoman("XI");
			var number7 = romanNumeral.GetArabicFromRoman("XII");
			var number8 = romanNumeral.GetArabicFromRoman("XIII");

			// Assert
			Assert.AreEqual(9, number4);
			Assert.AreEqual(10, number5);
			Assert.AreEqual(11, number6);
			Assert.AreEqual(12, number7);
			Assert.AreEqual(13, number8);
		}
	}
}

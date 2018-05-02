using System;
using System.Collections.Generic;
using System.Linq;
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
			var expected = new List<string>
			{
				"I", "II", "III"
			};
			// Act
			var actual = romanNumeral.RangeRomanList(1, 3);			
			// Assert
			CollectionAssert.AreEqual(expected, actual);           
		}

		[TestMethod]
		public void RomanNumeral_4to8()
		{
			// Arrange
			var romanNumeral = new RomanNumeral();
			var expected = new List<string>
			{
				"IV", "V", "VI", "VII", "VIII"
			};
			// Act
			var actual = romanNumeral.RangeRomanList(4, 5);			
			// Assert
			CollectionAssert.AreEqual(expected, actual);			
		}

		[TestMethod]
		public void RomanNumeral_9to13()
		{
			// Arrange
			var romanNumeral = new RomanNumeral();
			var expected = new List<string>
			{
				"IX", "X", "XI", "XII", "XIII"
			};
			// Act
			var actual = romanNumeral.RangeRomanList(9, 5);
			// Assert
			CollectionAssert.AreEqual(expected, actual);			
		}

		[TestMethod]
		public void RomanNumeral_14to18()
		{
			// Arrange
			var romanNumeral = new RomanNumeral();
			var expected = new List<string>
			{
				"XIV", "XV", "XVI", "XVII", "XVIII"
			};
			// Act
			var actual = romanNumeral.RangeRomanList(14, 5);			
			// Assert
			CollectionAssert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void RomanNumeral_3709()
		{
			// Arrange
			var romanNumeral = new RomanNumeral();
			// Act
			var number = romanNumeral.GetRomanValueFromArabicNum(3709);
			// Assert
			Assert.AreEqual("MMMDCCIX", number);
		}

		[TestMethod]
		public void RomanNumeral_Maximum()
		{
			// Arrange
			var romanNumeral = new RomanNumeral();
			// Act
			var number = romanNumeral.GetRomanValueFromArabicNum(Constants.Roman.MaxAllowedNumber);
			// Assert
			Assert.AreEqual(Constants.Roman.MaxAllowedNumeral, number);
		}

		[TestMethod]
		[ExpectedException(typeof(KeyNotFoundException))]
		public void Roman2Arabic_KeyNotFound()
		{
			// Arrange
			var romanNumeral = new RomanNumeral();
			// Act
			romanNumeral.GetArabicFromRoman("DUX");
			// Assert
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentNullException))]
		public void Roman2Arabic_ArgumentNull()
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
			var expected = Enumerable.Range(1, 3).ToList();
			// Act
			var actual = new List<int>
			{
				romanNumeral.GetArabicFromRoman("I"),
				romanNumeral.GetArabicFromRoman("II"),
				romanNumeral.GetArabicFromRoman("III")
			};
			// Assert
			CollectionAssert.AreEqual(expected, actual);			
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
		public void Roman2Arabic_Maximum()
		{
			// Arrange
			var romanNumeral = new RomanNumeral();
			// Act
			var number = romanNumeral.GetArabicFromRoman(Constants.Roman.MaxAllowedNumeral);
			// Assert
			Assert.AreEqual(Constants.Roman.MaxAllowedNumber, number);
		}

		[TestMethod]
		public void Roman2Arabic_4to8()
		{
			// Arrange
			var romanNumeral = new RomanNumeral();
			var expected = Enumerable.Range(4, 5).ToList();
			// Act			
			var actual = new List<int>
			{
				romanNumeral.GetArabicFromRoman("IV"),
				romanNumeral.GetArabicFromRoman("V"),
				romanNumeral.GetArabicFromRoman("VI"),
				romanNumeral.GetArabicFromRoman("VII"),
				romanNumeral.GetArabicFromRoman("VIII")
			};			
			// Assert
			CollectionAssert.AreEqual(expected, actual);			
		}

		[TestMethod]
		public void Roman2Arabic_9to13()
		{
			// Arrange
			var romanNumeral = new RomanNumeral();
			var expected = Enumerable.Range(9, 5).ToList();
			// Act
			var actual = new List<int>
			{
				romanNumeral.GetArabicFromRoman("IX"),
				romanNumeral.GetArabicFromRoman("X"),
				romanNumeral.GetArabicFromRoman("XI"),
				romanNumeral.GetArabicFromRoman("XII"),
				romanNumeral.GetArabicFromRoman("XIII")
			};
			// Assert
			CollectionAssert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void Roman2Arabic_14to18()
		{
			// Arrange
			var romanNumeral = new RomanNumeral();
			var expected = Enumerable.Range(14, 5).ToList();
			// Act
			var actual = new List<int>
			{
				romanNumeral.GetArabicFromRoman("XIV"),
				romanNumeral.GetArabicFromRoman("XV"),
				romanNumeral.GetArabicFromRoman("XVI"),
				romanNumeral.GetArabicFromRoman("XVII"),
				romanNumeral.GetArabicFromRoman("XVIII")
			};
			// Assert
			CollectionAssert.AreEqual(expected, actual);
		}
	}
}

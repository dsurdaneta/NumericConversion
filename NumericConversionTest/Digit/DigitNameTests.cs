﻿using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DsuDev.NumericConversion.Test.Digit
{
	[TestClass]
	public class DigitNameTests
	{
		[TestMethod]
		public void DigitName_IsNotNull()
		{
			//Act
			var sut = new DigitName();
			//Assert
			Assert.IsNotNull(sut);
		}

		[TestMethod]
		public void DigitName_Translate9()
		{
			//Arrange
			var digitName = new DigitName();
			//Act
			var sut = digitName.Translate(9);
			//Assert
			Assert.AreEqual("Nine", sut);
		}
		
		[TestMethod]
		public void DigitName_Translate0()
		{
			//Arrange
			var digitName = new DigitName();
			//Act
			var sut = digitName.Translate(0);
			//Assert
			Assert.AreEqual("Zero", sut);
		}

		[TestMethod]
		public void DigitName_TranslateFour()
		{
			//Arrange
			var digitName = new DigitName();
			//Act
			var sut = digitName.Translate("Four");
			//Assert
			Assert.AreEqual(4, sut);
		}

		[TestMethod]
		public void DigitName_TranslateZero()
		{
			//Arrange
			var digitName = new DigitName();
			//Act
			var sut = digitName.Translate("Zero");
			//Assert
			Assert.AreEqual(0, sut);
		}

		[TestMethod]
		[ExpectedException(typeof(InvalidCastException))]
		public void DigitName_TranslateEmptyString()
		{
			//Arrange
			var digitName = new DigitName();
			//Act
			digitName.Translate(string.Empty);
		}

		[TestMethod]
		[ExpectedException(typeof(NullReferenceException))]
		public void DigitName_TranslateNullString()
		{
			//Arrange
			var digitName = new DigitName();
			//Act
			digitName.Translate(null);
		}

		[TestMethod]
		public void DigitName_TranslateNegativeNumber()
		{
			//Arrange
			var digitName = new DigitName();
			//Act
			var sut = digitName.Translate(-2);
			//Assert
			Assert.AreEqual(string.Empty, sut);
		}

		[TestMethod]
		[ExpectedException(typeof(InvalidCastException))]
		public void DigitName_TranslateNotAlphanumeric()
		{
			//Arrange
			var digitName = new DigitName();
			//Act
			digitName.Translate("*#...");
		}

		[TestMethod]
		public void DigitName_TranslateBigNumber()
		{
			//Arrange
			var digitName = new DigitName();
			//Act
			var sut = digitName.Translate(12354);
			//Assert
			Assert.AreEqual(string.Empty, sut);
		}

		[TestMethod]
		public void DigitName_TranslateSeveralDigits()
		{
			//Arrange
			var digitName = new DigitName();
			//Act
			var sut = digitName.TranslateSeveralDigits(354);
			//Assert
			Assert.AreEqual("ThreeFiveFour", sut);
		}

		[TestMethod]
		public void DigitName_GetDigitNameList()
		{
			//Arrange
			var digitName = new DigitName();
			var expected = new List<string>
			{
				"One","Two","Three"
			};
			//Act
			var sut = digitName.GetDigitNameList(123);
			//Assert
			CollectionAssert.AreEqual(expected, sut);
		}

		[TestMethod]
		public void DigitName_GetNumberFromDigitNameList()
		{
			//Arrange
			var digitName = new DigitName();
			var digitNameList = new List<string>
			{
				"Two","Six","Eight"
			};
			//Act
			var sut = digitName.GetNumberFromDigitNameList(digitNameList);
			//Assert
			Assert.AreEqual(268, sut);
		}

		[TestMethod]
		public void DigitName_GetNumberFromDigitNameString()
		{
			//Arrange
			var digitName = new DigitName();
			//Act
			var sut = digitName.GetNumberFromDigitNameString("SevenZeroFive");
			//Assert
			Assert.AreEqual(705, sut);
		}

		[TestMethod]
		[ExpectedException(typeof(InvalidOperationException))]
		public void DigitName_InvalidStringOfDigits()
		{
			//Arrange
			var digitName = new DigitName();
			//Act
			digitName.GetNumberFromDigitNameString("HelloWord");
		}
	}
}

using System;
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
		[ExpectedException(typeof(InvalidOperationException))]
		public void DigitName_TranslateEmptyString()
		{
			//Arrange
			var digitName = new DigitName();
			//Act
			var sut = digitName.Translate("");
		}

		[TestMethod]
		[ExpectedException(typeof(NullReferenceException))]
		public void DigitName_TranslateNullString()
		{
			//Arrange
			var digitName = new DigitName();
			//Act
			var sut = digitName.Translate(null);
		}

		[TestMethod]
		public void DigitName_TranslateNegativeNumber()
		{
			//Arrange
			var digitName = new DigitName();
			//Act
			var sut = digitName.Translate(-2);
			//Assert
			Assert.AreEqual("", sut);
		}
	}
}

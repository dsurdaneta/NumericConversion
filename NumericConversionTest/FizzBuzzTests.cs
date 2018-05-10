using System;
using System.Collections.Generic;
using DsuDev.NumericConversion.Constants;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DsuDev.NumericConversion.Test.Fizz
{
	[TestClass]
	public class FizzBuzzTests
	{
		[TestMethod]
		public void FizzBuzz_IsNotNull()
		{
			// Arrange
			var sut = new FizzBuzz();
			// Assert
			Assert.IsNotNull(sut);
		}		      

		[TestMethod]
		public void FizzBuzz_IsFizz()
		{
			// Arrange
			var fizzBuzz = new FizzBuzz();
			// Act
			var sut = fizzBuzz.GetFizzBuzz(3);			
			// Assert
			Assert.AreEqual(Wordzz.Fizz, sut);
		}

		[TestMethod]
		public void FizzBuzz_IsBuzz()
		{
			// Arrange
			var fizzBuzz = new FizzBuzz();
			// Act
			var sut = fizzBuzz.GetFizzBuzz(5);
			// Assert
			Assert.AreEqual(Wordzz.Buzz, sut);
		}

		[TestMethod]
		public void FizzBuzz_IsFizzBuzz()
		{
			// Arrange
			var fizzBuzz = new FizzBuzz();
			var expected = Wordzz.Fizz + Wordzz.Buzz;
			// Act
			var sut = fizzBuzz.GetFizzBuzz(15);
			// Assert
			Assert.AreEqual(expected, sut);
		}

		[TestMethod]
		public void FizzBuzz_IsWhizz()
		{
			// Arrange
			var fizzBuzz = new FizzBuzz();
			// Act
			var sut = fizzBuzz.GetFizzBuzz(7);
			// Assert
			Assert.AreEqual(Wordzz.Whizz, sut);
		}

		[TestMethod]
		public void FizzBuzz_IsFizzWhizz()
		{
			// Arrange
			var fizzBuzz = new FizzBuzz();
			var expected = Wordzz.Fizz + Wordzz.Whizz;
			// Act
			var sut = fizzBuzz.GetFizzBuzz(21);
			// Assert
			Assert.AreEqual(expected, sut);
		}

		[TestMethod]
		public void FizzBuzz_IsBuzzWhizz()
		{
			// Arrange
			var fizzBuzz = new FizzBuzz();
			var expected = Wordzz.Buzz + Wordzz.Whizz;
			// Act
			var sut = fizzBuzz.GetFizzBuzz(35);
			// Assert
			Assert.AreEqual(expected, sut);
		}

		[TestMethod]
		public void FizzBuzz_IsFizzBuzzWhizz()
		{
			// Arrange
			var fizzBuzz = new FizzBuzz();
			var expected = Wordzz.Fizz + Wordzz.Buzz + Wordzz.Whizz;
			// Act
			var sut = fizzBuzz.GetFizzBuzz(105);
			// Assert
			Assert.AreEqual(expected, sut);
		}

		[TestMethod]
		public void FizzBuzz_JustANumber()
		{
			// Arrange
			var fizzBuzz = new FizzBuzz();
			// Act
			var sut = fizzBuzz.GetFizzBuzz(11);
			// Assert
			Assert.AreEqual("11", sut);
		}

		[TestMethod]
		public void FizzBuzz_IsZero()
		{
			// Arrange
			var fizzBuzz = new FizzBuzz();
			// Act			
			var sut = fizzBuzz.GetFizzBuzz(0);
			// Assert
			Assert.AreEqual("0", sut);
		}

		[TestMethod]
		public void FizzBuzz_NegativeWord()
		{
			// Arrange
			var fizzBuzz = new FizzBuzz();
			// Act
			var sut = fizzBuzz.GetFizzBuzz(-10);
			// Assert
			Assert.AreEqual(Wordzz.Buzz, sut);
		}
		
		[TestMethod]
		public void FizzBuzz_NegativeNumber()
		{
			// Arrange
			var fizzBuzz = new FizzBuzz();
			// Act
			var sut = fizzBuzz.GetFizzBuzz(-8);
			// Assert
			Assert.AreEqual("-8", sut);
		}

		[TestMethod]
		public void FizzBuzz_ZeroList()
		{
			// Arrange
			var fizzBuzz = new FizzBuzz();
			var expected = new List<string>();
			// Act
			var sut = fizzBuzz.GenerateFizzBuzzList(0);
			// Assert
			CollectionAssert.AreEqual(expected, sut);
		}

		[TestMethod]
		public void FizzBuzz_ZeroListIncludeZero()
		{
			// Arrange
			var fizzBuzz = new FizzBuzz();
			var expected = new List<string> { "0" };
			// Act
			var sut = fizzBuzz.GenerateFizzBuzzList(0, true);
			// Assert
			CollectionAssert.AreEqual(expected, sut);
		}

		[TestMethod]
		public void FizzBuzz_10List()
		{
			// Arrange
			var fizzBuzz = new FizzBuzz();
			var expected = new List<string>
			{
				"1", "2", Wordzz.Fizz, "4", Wordzz.Buzz, Wordzz.Fizz, Wordzz.Whizz, "8", Wordzz.Fizz, Wordzz.Buzz
			};
			// Act
			var sut = fizzBuzz.GenerateFizzBuzzList(10);
			// Assert
			CollectionAssert.AreEqual(expected, sut);
		}

		[TestMethod]
		public void FizzBuzz_10ListIncludeZero()
		{
			// Arrange
			var fizzBuzz = new FizzBuzz();
			var expected = new List<string>
			{
				"0", "1", "2", Wordzz.Fizz, "4", Wordzz.Buzz, Wordzz.Fizz, Wordzz.Whizz, "8", Wordzz.Fizz, Wordzz.Buzz
			};
			// Act
			var sut = fizzBuzz.GenerateFizzBuzzList(10, true);
			// Assert
			CollectionAssert.AreEqual(expected, sut);
		}

		[TestMethod]
		public void FizzBuzz_Negative10List()
		{
			// Arrange
			var fizzBuzz = new FizzBuzz();
			var expected = new List<string>
			{
				"-1", "-2", Wordzz.Fizz, "-4", Wordzz.Buzz, Wordzz.Fizz, Wordzz.Whizz, "-8", Wordzz.Fizz, Wordzz.Buzz
			};
			// Act
			var sut = fizzBuzz.GenerateNegativeFizzBuzzList(-10);
			// Assert
			CollectionAssert.AreEqual(expected, sut);
		}

		[TestMethod]
		public void FizzBuzz_Negative10ListIncludeZero()
		{
			// Arrange
			var fizzBuzz = new FizzBuzz();
			var expected = new List<string>
			{
				"0", "-1", "-2", Wordzz.Fizz, "-4", Wordzz.Buzz, Wordzz.Fizz, Wordzz.Whizz, "-8", Wordzz.Fizz, Wordzz.Buzz
			};
			// Act
			var sut = fizzBuzz.GenerateNegativeFizzBuzzList(-10, true);
			// Assert
			CollectionAssert.AreEqual(expected, sut);
		}

		[TestMethod]
		public void FizzBuzz_Negative10ListWithReverseFalse()
		{
			// Arrange
			var fizzBuzz = new FizzBuzz();
			var expected = new List<string>
			{
				Wordzz.Buzz, Wordzz.Fizz, "-8", Wordzz.Whizz, Wordzz.Fizz, Wordzz.Buzz, "-4", Wordzz.Fizz, "-2", "-1"
			};
			// Act
			var sut = fizzBuzz.GenerateNegativeFizzBuzzList(-10, reverse: false);
			// Assert
			CollectionAssert.AreEqual(expected, sut);
		}
		
		[TestMethod]
		public void FizzBuzz_30List()
		{
			// Arrange
			var fizzBuzz = new FizzBuzz();
			var expected = new List<string>
			{
				"1", "2", Wordzz.Fizz, "4", Wordzz.Buzz, Wordzz.Fizz, Wordzz.Whizz, "8", Wordzz.Fizz, Wordzz.Buzz,
				"11", Wordzz.Fizz, "13", Wordzz.Whizz, Wordzz.Fizz + Wordzz.Buzz, "16", "17", Wordzz.Fizz, "19", Wordzz.Buzz,
				Wordzz.Fizz + Wordzz.Whizz, "22", "23", Wordzz.Fizz, Wordzz.Buzz, "26", Wordzz.Fizz, Wordzz.Whizz, "29",
				Wordzz.Fizz + Wordzz.Buzz
			};
			// Act
			var sut = fizzBuzz.GenerateFizzBuzzList(30);
			// Assert
			CollectionAssert.AreEqual(expected, sut);
		}

		[TestMethod]
		public void FizzBuzz_GetFizzNumber()
		{
			// Arrange
			var fizzBuzz = new FizzBuzz();
			//Act
			var sut = fizzBuzz.GetNumberFromFizzBuzz(Wordzz.Fizz);
			//Assert
			Assert.AreEqual(3, sut);
		}

		[TestMethod]
		public void FizzBuzz_GetBuzzNumber()
		{
			// Arrange
			var fizzBuzz = new FizzBuzz();
			//Act
			var sut = fizzBuzz.GetNumberFromFizzBuzz(Wordzz.Buzz);
			//Assert
			Assert.AreEqual(5, sut);
		}

		[TestMethod]
		public void FizzBuzz_GetWhizzNumber()
		{
			// Arrange
			var fizzBuzz = new FizzBuzz();
			//Act
			var sut = fizzBuzz.GetNumberFromFizzBuzz(Wordzz.Whizz);
			//Assert
			Assert.AreEqual(7, sut);
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentNullException))]
		public void FizzBuzz_GetFizzBuzzNumberNullException()
		{
			// Arrange
			var fizzBuzz = new FizzBuzz();
			//Act
			fizzBuzz.GetNumberFromFizzBuzz(string.Empty);
		}

		[TestMethod]
		[ExpectedException(typeof(InvalidOperationException))]
		public void FizzBuzz_GetFizzBuzzNumberInvalidOperation()
		{
			// Arrange
			var fizzBuzz = new FizzBuzz();
			//Act
			fizzBuzz.GetNumberFromFizzBuzz("HelloWord");
		}
	}
}

using System.Collections.Generic;
using DsuDev.NumericConversion.Constants;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DsuDev.NumericConversion.Test.Fizz
{
	[TestClass]
    public class FizzBuzzTest
    {
        [TestMethod]
        public void FizzBuzz_isNotNull()
        {
            // Arrange
            var result = new FizzBuzz();
            // Assert
            Assert.IsNotNull(result);
        }		      

        [TestMethod]
        public void FizzBuzz_isFizz()
        {
            // Arrange
            var fizzBuzz = new FizzBuzz();
            // Act
            var result = fizzBuzz.GetFizzBuzz(3);			
			// Assert
			Assert.AreEqual(Wordzz.Fizz, result);
        }

        [TestMethod]
        public void FizzBuzz_isBuzz()
        {
            // Arrange
            var fizzBuzz = new FizzBuzz();
            // Act
            var result = fizzBuzz.GetFizzBuzz(5);
            // Assert
            Assert.AreEqual(Wordzz.Buzz, result);
        }

        [TestMethod]
        public void FizzBuzz_isFizzBuzz()
        {
            // Arrange
            var fizzBuzz = new FizzBuzz();
            var expected = Wordzz.Fizz + Wordzz.Buzz;
            // Act
            var result = fizzBuzz.GetFizzBuzz(15);
            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void FizzBuzz_isWhizz()
        {
            // Arrange
            var fizzBuzz = new FizzBuzz();
            // Act
            var result = fizzBuzz.GetFizzBuzz(7);
            // Assert
            Assert.AreEqual(Wordzz.Whizz, result);
        }

        [TestMethod]
        public void FizzBuzz_isFizzWhizz()
        {
            // Arrange
            var fizzBuzz = new FizzBuzz();
            var expected = Wordzz.Fizz + Wordzz.Whizz;
            // Act
            var result = fizzBuzz.GetFizzBuzz(21);
            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void FizzBuzz_isBuzzWhizz()
        {
            // Arrange
            var fizzBuzz = new FizzBuzz();
            var expected = Wordzz.Buzz + Wordzz.Whizz;
            // Act
            var result = fizzBuzz.GetFizzBuzz(35);
            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void FizzBuzz_isFizzBuzzWhizz()
        {
            // Arrange
            var fizzBuzz = new FizzBuzz();
            var expected = Wordzz.Fizz + Wordzz.Buzz + Wordzz.Whizz;
            // Act
            var result = fizzBuzz.GetFizzBuzz(105);
            // Assert
            Assert.AreEqual(expected, result);
        }

		[TestMethod]
		public void FizzBuzz_justANumber()
		{
			// Arrange
			var fizzBuzz = new FizzBuzz();
			// Act
			var result = fizzBuzz.GetFizzBuzz(11);
			// Assert
			Assert.AreEqual("11", result);
		}

		[TestMethod]
		public void FizzBuzz_isZero()
		{
			// Arrange
			var fizzBuzz = new FizzBuzz();
			// Act			
			var result = fizzBuzz.GetFizzBuzz(0);
			// Assert
			Assert.AreEqual("0", result);
		}

		[TestMethod]
		public void FizzBuzz_negativeWord()
		{
			// Arrange
			var fizzBuzz = new FizzBuzz();
			// Act
			var result = fizzBuzz.GetFizzBuzz(-10);
			// Assert
			Assert.AreEqual(Wordzz.Buzz, result);
		}


		[TestMethod]
		public void FizzBuzz_negativeNumber()
		{
			// Arrange
			var fizzBuzz = new FizzBuzz();
			// Act
			var result = fizzBuzz.GetFizzBuzz(-8);
			// Assert
			Assert.AreEqual("-8", result);
		}
		[TestMethod]
		public void FizzBuzz_zeroList()
		{
			// Arrange
			var fizzBuzz = new FizzBuzz();
			var expected = new List<string>();
			// Act
			var result = fizzBuzz.GenerateFizzBuzzList(0);
			// Assert
			CollectionAssert.AreEqual(expected, result);
		}

		[TestMethod]
		public void FizzBuzz_zeroListIncludeZero()
		{
			// Arrange
			var fizzBuzz = new FizzBuzz();
			var expected = new List<string> { "0" };
			// Act
			var result = fizzBuzz.GenerateFizzBuzzList(0, true);
			// Assert
			CollectionAssert.AreEqual(expected, result);
		}

		[TestMethod]
		public void FizzBuzz_10List()
		{
			// Arrange
			var fizzBuzz = new FizzBuzz();
			var expected = new List<string> { "1", "2", Wordzz.Fizz, "4", Wordzz.Buzz, Wordzz.Fizz, Wordzz.Whizz, "8", Wordzz.Fizz, Wordzz.Buzz };
			// Act
			var result = fizzBuzz.GenerateFizzBuzzList(10);
			// Assert
			CollectionAssert.AreEqual(expected, result);
		}

		[TestMethod]
		public void FizzBuzz_10ListIncludeZero()
		{
			// Arrange
			var fizzBuzz = new FizzBuzz();
			var expected = new List<string> { "0", "1", "2", Wordzz.Fizz, "4", Wordzz.Buzz, Wordzz.Fizz, Wordzz.Whizz, "8", Wordzz.Fizz, Wordzz.Buzz };
			// Act
			var result = fizzBuzz.GenerateFizzBuzzList(10, true);
			// Assert
			CollectionAssert.AreEqual(expected, result);
		}

		[TestMethod]
		public void FizzBuzz_negative10List()
		{
			// Arrange
			var fizzBuzz = new FizzBuzz();
			var expected = new List<string> { "-1", "-2", Wordzz.Fizz, "-4", Wordzz.Buzz, Wordzz.Fizz, Wordzz.Whizz, "-8", Wordzz.Fizz, Wordzz.Buzz };
			// Act
			var result = fizzBuzz.GenerateNegativeFizzBuzzList(-10);
			// Assert
			CollectionAssert.AreEqual(expected, result);
		}

		[TestMethod]
		public void FizzBuzz_negative10ListIncludeZero()
		{
			// Arrange
			var fizzBuzz = new FizzBuzz();
			var expected = new List<string> { "0", "-1", "-2", Wordzz.Fizz, "-4", Wordzz.Buzz, Wordzz.Fizz, Wordzz.Whizz, "-8", Wordzz.Fizz, Wordzz.Buzz };
			// Act
			var result = fizzBuzz.GenerateNegativeFizzBuzzList(-10, true);
			// Assert
			CollectionAssert.AreEqual(expected, result);
		}

		[TestMethod]
		public void FizzBuzz_negative10ListWithReverseFalse()
		{
			// Arrange
			var fizzBuzz = new FizzBuzz();
			var expected = new List<string> { Wordzz.Buzz, Wordzz.Fizz, "-8", Wordzz.Whizz, Wordzz.Fizz, Wordzz.Buzz, "-4", Wordzz.Fizz, "-2", "-1" };
			// Act
			var result = fizzBuzz.GenerateNegativeFizzBuzzList(-10, reverse: false);
			// Assert
			CollectionAssert.AreEqual(expected, result);
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
				Wordzz.Fizz + Wordzz.Whizz, "22", "23", Wordzz.Fizz, Wordzz.Buzz, "26", Wordzz.Fizz, Wordzz.Whizz, "29", Wordzz.Fizz + Wordzz.Buzz
			};
			// Act
			var result = fizzBuzz.GenerateFizzBuzzList(30);
			// Assert
			CollectionAssert.AreEqual(expected, result);
		}
	}
}

using System.Collections.Generic;
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
			Assert.AreEqual(FizzBuzz.Fizz, result);
        }

        [TestMethod]
        public void FizzBuzz_isBuzz()
        {
            // Arrange
            var fizzBuzz = new FizzBuzz();
            // Act
            var result = fizzBuzz.GetFizzBuzz(5);
            // Assert
            Assert.AreEqual(FizzBuzz.Buzz, result);
        }

        [TestMethod]
        public void FizzBuzz_isFizzBuzz()
        {
            // Arrange
            var fizzBuzz = new FizzBuzz();
            var expected = FizzBuzz.Fizz + FizzBuzz.Buzz;
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
            Assert.AreEqual(FizzBuzz.Whizz, result);
        }

        [TestMethod]
        public void FizzBuzz_isFizzWhizz()
        {
            // Arrange
            var fizzBuzz = new FizzBuzz();
            var expected = FizzBuzz.Fizz + FizzBuzz.Whizz;
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
            var expected = FizzBuzz.Buzz + FizzBuzz.Whizz;
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
            var expected = FizzBuzz.Fizz + FizzBuzz.Buzz + FizzBuzz.Whizz;
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
		public void FizzBuzz_negativeNumber()
		{
			// Arrange
			var fizzBuzz = new FizzBuzz();
			// Act
			var result = fizzBuzz.GetFizzBuzz(-10);
			// Assert
			Assert.AreEqual(FizzBuzz.Buzz, result);
		}

		[TestMethod]
		public void FizzBuzzZeroList()
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
		public void FizzBuzz10List()
		{
			// Arrange
			var fizzBuzz = new FizzBuzz();
			var expected = new List<string> { "1", "2", FizzBuzz.Fizz, "4", FizzBuzz.Buzz, FizzBuzz.Fizz, FizzBuzz.Whizz, "8", FizzBuzz.Fizz, FizzBuzz.Buzz };

			// Act
			var result = fizzBuzz.GenerateFizzBuzzList(10);
			// Assert
			CollectionAssert.AreEqual(expected, result);

		}

		[TestMethod]
		public void FizzBuzz30List()
		{
			// Arrange
			var fizzBuzz = new FizzBuzz();
			var expected = new List<string> {
				"1", "2", FizzBuzz.Fizz, "4", FizzBuzz.Buzz, FizzBuzz.Fizz, FizzBuzz.Whizz, "8", FizzBuzz.Fizz, FizzBuzz.Buzz,
				"11", FizzBuzz.Fizz, "13", FizzBuzz.Whizz, FizzBuzz.Fizz + FizzBuzz.Buzz, "16", "17", FizzBuzz.Fizz, "19", FizzBuzz.Buzz,
				FizzBuzz.Fizz + FizzBuzz.Whizz, "22", "23", FizzBuzz.Fizz, FizzBuzz.Buzz, "26", FizzBuzz.Fizz, FizzBuzz.Whizz, "29", FizzBuzz.Fizz + FizzBuzz.Buzz
			};

			// Act
			var result = fizzBuzz.GenerateFizzBuzzList(30);
			// Assert
			CollectionAssert.AreEqual(expected, result);
		}
	}
}

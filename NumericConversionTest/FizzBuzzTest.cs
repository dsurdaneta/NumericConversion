using System;
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
	}
}

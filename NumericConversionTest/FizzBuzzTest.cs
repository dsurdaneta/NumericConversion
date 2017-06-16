using System;
using DsuDev.NumericConversion;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NumericConversion.Test
{
    [TestClass]
    public class FizzBuzzTest
    {
        [TestMethod]
        public void FizzBuzz_isNotNull()
        {
            // Arrange
            var result = new FizzBuzz();

            // Act
            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void FizzBuzz_isNumeric()
        {
            // Arrange
            var fizzBuzz = new FizzBuzz();

            // Act
            var result = fizzBuzz.GetFizzBuzz(2);
            // Assert
            Assert.AreEqual("2", result);
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
        public void FizzBuzz_isIsBuzz()
        {
            // Arrange
            var fizzBuzz = new FizzBuzz();

            // Act
            var result = fizzBuzz.GetFizzBuzz(5);

            // Assert
            Assert.AreEqual(FizzBuzz.Buzz, result);
        }

        [TestMethod]
        public void FizzBuzz_isIsFizzBuzz()
        {
            // Arrange
            var fizzBuzz = new FizzBuzz();
            var expected = FizzBuzz.Fizz + FizzBuzz.Buzz;

            // Act
            var result = fizzBuzz.GetFizzBuzz(5);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void FizzBuzz_isWhizz()
        {
            // Arrange
            var fizzBuzz = new FizzBuzz();

            // Act
            var result = fizzBuzz.GetFizzBuzz(3);

            // Assert
            Assert.AreEqual(FizzBuzz.Whizz, result);
        }
    }
}

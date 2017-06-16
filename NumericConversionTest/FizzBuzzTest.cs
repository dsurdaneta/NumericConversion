using System;
using DsuDev.NumericConversion;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NumericConversion.Test
{
    [TestClass]
    public class FizzBuzzTest
    {
        [TestMethod]
        public void FizzBuzz_IsNotNull()
        {
            // Arrange
            var result = new FizzBuzz();

            // Act
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
        public void FizzBuzz_isIsBuzz()
        {
            // Arrange
            var fizzBuzz = new FizzBuzz();

            // Act
            var result = fizzBuzz.GetFizzBuzz(5);

            // Assert
            Assert.AreEqual(FizzBuzz.Buzz, result);
        }
    }
}

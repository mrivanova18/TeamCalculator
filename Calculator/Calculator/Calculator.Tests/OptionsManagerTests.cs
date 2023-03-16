using NUnit.Framework;
using System;

namespace Calculator.Tests
{
    public class OptionsManagerTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AddShouldAddsAAndB()
        {
            //Arrange
            double a = 25;
            double b = 2;
            string expectedResult = "25 + 2 = 27";

            //Act
            string actualResult = OptionsManager.Add(a, b);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void DevideShouldDevideAByB()
        {
            //Arrange
            double a = 16;
            double b = 4;

            //Act
            string actualResult = OptionsManager.Devide(a, b);

            //Assert
            Assert.AreEqual("16 / 4 = 4", actualResult);
        }

        [Test]
        public void DevideShouldThrowInvalidOperationExceptionWhenBIsZeroWithMessage()
        {
            //Arrange
            double a = 2;
            double b = 0;
            string message = "Is not divisible by zero";

            //Act
            var ex = Assert.Throws<InvalidOperationException>(() => OptionsManager.Devide(a, b));

            //Assert
            Assert.AreEqual(message, ex.Message);
        }
    }
}
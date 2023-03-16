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
            double a = 25;
            double b = 2;
            string expectedResult = "25 + 2 = 27";
            string actualResult = OptionsManager.Add(a, b);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void SubtractShouldWork()
        {
            double a = 25;
            double b = 2;
            string expectedResult = "25 - 2 = 23";
            string actualResult = OptionsManager.Subtract(a, b);
            Assert.AreEqual(expectedResult, actualResult);
        }         

        [Test]
        public void DevideShouldDevideAByB()
        {
            double a = 16;
            double b = 4;
            string actualResult = OptionsManager.Devide(a, b);
            Assert.AreEqual("16 / 4 = 4", actualResult);
        }

        [Test]
        public void DevideShouldThrowInvalidOperationExceptionWhenBIsZeroWithMessage()
        {
            double a = 2;
            double b = 0;
            string message = "Is not divisible by zero";
            var ex = Assert.Throws<InvalidOperationException>(() => OptionsManager.Devide(a, b));
            Assert.AreEqual(message, ex.Message);
        }
    }
}
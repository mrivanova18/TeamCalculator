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
            string expectedResult = "25+2=27";
            string actualResult = OptionsManager.Add(a, b);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void SubtractShouldWork()
        {
            double a = 25;
            double b = 2;
            string expectedResult = "25-2=23";
            string actualResult = OptionsManager.Subtract(a, b);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void DevideShouldDevideAByB()
        {
            double a = 16;
            double b = 4;
            string actualResult = OptionsManager.Devide(a, b);
            Assert.AreEqual("16/4=4", actualResult);
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

        [Test]
        public void MultiplyShouldMultiplyAAndB()
        {
            double a = 5;
            double b = 7;
            string expectedResult = "5*7=35";
            string actualResult = OptionsManager.Multiply(a, b);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void SubstractAbsShouldWork()
        {
            double a = 5;
            double b = 7;
            string expectedResult = "5-7=2";
            string actualResult = OptionsManager.SubtractAbs(a, b);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void DevideReminderShouldWork()
        {
            double a = 8;
            double b = 3;
            string expectedResult = "8/3=2";
            string actualResult = OptionsManager.DevideReminder(a, b);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void DevideReminderShouldThrow()
        {
            double a = 8;
            double b = 0;
            string message = "Is not divisible by zero";
            var ex = Assert.Throws<InvalidOperationException>(() => OptionsManager.DevideReminder(a, b));
            Assert.AreEqual(message, ex.Message);
        }

        [Test]
        public void PowerShouldWork()
        {
            double a = 2;
            double b = 3;
            string expectedResult = "2^3=8";
            string actualResult = OptionsManager.Power(a, b);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void MinimumShouldWork()
        {
            double a = 2;
            double b = 3;
            string expectedResult = "Min(2,3)=2";
            string actualResult = OptionsManager.Minimum(a, b);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void MaximumShouldWork()
        {
            double a = 2;
            double b = 3;
            string expectedResult = "Max(2,3)=3";
            string actualResult = OptionsManager.Maximum(a, b);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}


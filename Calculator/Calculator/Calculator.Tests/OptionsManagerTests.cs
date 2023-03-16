using NUnit.Framework;

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
        public void SubtractShouldWork()
        {
            double a = 25;
            double b = 2;
            string expectedResult = "25 - 2 = 23";
            string actualResult = OptionsManager.Subtract(a, b);
            Assert.AreEqual(expectedResult, actualResult);
        }
            
    }
}
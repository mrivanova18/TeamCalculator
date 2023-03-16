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

            public void MultiplyShouldMultiplyAAndB()
            {
                double a = 5;
                double b = 7;
                string expectedResult = "5 * 7 = 35";

                string actualResult = OptionsManager.Multiply(a, b);

                Assert.AreEqual(expectedResult, actualResult);
            }
        }
    }
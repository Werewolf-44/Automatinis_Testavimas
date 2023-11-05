using Calculator;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorUnitTests
{
    public class Tests
    {
        [Test]
        public void TestSum()
        {
            // Arrange
            int number1 = 5;
            int number2 = 2;
            int expectedResult = 7;

            //Acts
            int actualResult = Methods.Sum(number1, number2);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
            Assert.IsTrue(actualResult == expectedResult);
        }

        [TestCase(5, 2, 2.5)]
        public void TestDivision(int number1, int number2, double expectedResult)
        {
            double actualResult = Methods.Divide(number1, number2);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

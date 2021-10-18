using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestPractice;

namespace UnitTestPracticeCore.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void TestSumTwoNumbers()
        {
            // Arrange
            var op = new Operations();
            double[] numeros = new double[] { 1, 2, 2, 4 };
            string[] simbolos = new string[] { "+", "-", "+" };
            var expectedResult = 5;

            // Act
            var result = op.DoOperation(numeros, simbolos);

            // Assert
            Assert.AreEqual(result, expectedResult);
        }

    }
}
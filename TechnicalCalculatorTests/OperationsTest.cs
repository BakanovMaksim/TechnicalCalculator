using System;
using NUnit.Framework;
using TechnicalCalculator.BL.Model;

namespace TechnicalCalculatorTests
{
    [TestFixture]
    public class OperationsTest
    {
        [Test]
        public void BinaryOperation_InputArgument_ReturnedValue()
        {
            //Arrange
            var operations = new Operations();
            var firstNumber = new FirstNumber(8);
            var secondNumber = new SecondNumber(4);

            //Act
            var resultAddition = operations.Addition(firstNumber, secondNumber);
            var resultSubsctraction = operations.Subsctraction(firstNumber, secondNumber);
            var resultMultiplication = operations.Multiplication(firstNumber, secondNumber);
            var resultDivision = operations.Division(firstNumber, secondNumber);

            //Assert
            Assert.AreEqual(12, resultAddition.Value);
            Assert.AreEqual(4, resultSubsctraction.Value);
            Assert.AreEqual(32, resultMultiplication.Value);
            Assert.AreEqual(2, resultDivision.Value);
        }
    }
}

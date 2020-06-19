using System;
using NUnit.Framework;
using TechnicalCalculator.BL.Model;
using TechnicalCalculator.BL.Model.Operations;

namespace TechnicalCalculatorTests
{
    [TestFixture]
    public class OperationsTest
    {
        [Test]
        public void BinaryOperation_InputArgument_ReturnedValue()
        {
            //Arrange
            var firstNumber = new Number() { Value = 9 };
            var secondNumber = new Number() { Value = 4 };

            //Act
            var resultAddition = BinaryOperations.Addition(firstNumber, secondNumber);
            var resultSubsctraction = BinaryOperations.Subsctraction(firstNumber, secondNumber);
            var resultMultiplication = BinaryOperations.Multiplication(firstNumber, secondNumber);
            var resultDivision = BinaryOperations.Division(firstNumber, secondNumber);
            var resultDivisionReaminder = BinaryOperations.DivisionReaminder(firstNumber, secondNumber);

            //Assert
            Assert.AreEqual(13, resultAddition.Value);
            Assert.AreEqual(5, resultSubsctraction.Value);
            Assert.AreEqual(36, resultMultiplication.Value);
            Assert.AreEqual(2.25, resultDivision.Value);
            Assert.AreEqual(1, resultDivisionReaminder.Value);
        }

        [Test]
        public void UnaryOperation_InputArgument_ReturnedValue()
        {
            //Arrange
            var firstNumber = new Number() { Value = 5 };
            var secondNumber = new Number() { Value = 3 };

            //Act
            var resultExponentiation = UnaryOperations.Exponentiation(firstNumber, secondNumber);
            var resultFactorial = UnaryOperations.Factorial(firstNumber);

            //Assert
            Assert.AreEqual(125, resultExponentiation.Value);
            Assert.AreEqual(120, resultFactorial.Value);
        }
    }
}

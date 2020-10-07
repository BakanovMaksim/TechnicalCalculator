using NUnit.Framework;
using TechnicalCalculator.BL.Model;
using TechnicalCalculator.BL.Model.Operations;

namespace TechnicalCalculatorTests
{
    [TestFixture]
    public class OperationsTest
    {
        [TestCase(9,4,13)]
        [Category("Binary operation")]
        public void AdditionInputArgumentReturnedValue(int leftValue, int rightValue, int expectedValue)
        {
            var leftNumber = new Number() { Value = leftValue };
            var rightNumber = new Number() { Value = rightValue };

            var result = BinaryOperations.Addition(leftNumber, rightNumber);

            Assert.AreEqual(expectedValue, result.Value);
        }

        [TestCase(9, 4,5)]
        [Category("Binary operation")]
        public void SubstractionInputArgumentReturnedValue(int leftValue, int rightValue, int expectedValue)
        {
            var leftNumber = new Number() { Value = leftValue };
            var rightNumber = new Number() { Value = rightValue };

            var result = BinaryOperations.Subsctraction(leftNumber, rightNumber);

            Assert.AreEqual(expectedValue, result.Value);
        }

        [TestCase(9, 4, 36)]
        [Category("Binary operation")]
        public void MultiplicationInputArgumentReturnedValue(int leftValue, int rightValue, int expectedValue)
        {
            var leftNumber = new Number() { Value = leftValue };
            var rightNumber = new Number() { Value = rightValue };

            var result = BinaryOperations.Multiplication(leftNumber, rightNumber);

            Assert.AreEqual(expectedValue, result.Value);
        }

        [TestCase(9, 4, 2.25)]
        [Category("Binary operation")]
        public void DivisionInputArgumentReturnedValue(int leftValue, int rightValue, double expectedValue)
        {
            var leftNumber = new Number() { Value = leftValue };
            var rightNumber = new Number() { Value = rightValue };

            var result = BinaryOperations.Division(leftNumber, rightNumber);

            Assert.AreEqual(expectedValue, result.Value);
        }

        [TestCase(9, 4, 1)]
        [Category("Binary operation")]
        public void DivisionReaminderInputArgumentReturnedValue(int leftValue, int rightValue, int expectedValue)
        {
            var leftNumber = new Number() { Value = leftValue };
            var rightNumber = new Number() { Value = rightValue };

            var result = BinaryOperations.DivisionReaminder(leftNumber, rightNumber);

            Assert.AreEqual(expectedValue, result.Value);
        }

        [TestCase(5,3,125)]
        [Category("Unary operation")]
        public void ExponentiationInputArgumentReturnedValue(int leftValue,int rightValue, int expectedValue)
        {
            var leftNumber = new Number() { Value = leftValue };
            var rightNumber = new Number() { Value = rightValue };

            var result = UnaryOperations.Exponentiation(leftNumber, rightNumber);

            Assert.AreEqual(expectedValue, result.Value);
        }

        [TestCase(5,120)]
        [Category("Unary operation")]
        public void FactorialInputArgumentReturnedValue(int leftValue, int expectedValue)
        {
            var leftNumber = new Number() { Value = leftValue };

            var result = UnaryOperations.Factorial(leftNumber);

            Assert.AreEqual(expectedValue, result.Value);
        }
    }
}

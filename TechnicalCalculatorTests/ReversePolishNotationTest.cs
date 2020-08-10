using NUnit.Framework;
using TechnicalCalculator.BL.Model;
using TechnicalCalculator.BL.ViewModel;

namespace TechnicalCalculatorTests
{
    [TestFixture]
    public class ReversePolishNotationTest
    {
        [Test]
        public void GetExpression_InputArgument_ReturnExpression()
        {
            //Arrange
            var expression = "4*2+2";

            //Act
            var result = ReversePolishNotation.GetExpression(expression);

            //Assert
            Assert.AreEqual("4 2 * 2 + ", result);
        }

        [Test]
        public void Counting_InputArgument_ReturnResult()
        {
            //Arrange
            var expression = "4 2 * 2 + ";

            //Act
            var result = ReversePolishNotation.Counting(expression, new Number(), new Number());

            //Assert
            Assert.AreEqual(10, result.Value);
        }
    }
}

using System;
using NUnit.Framework;
using TechnicalCalculator.BL.Model;
using TechnicalCalculator.BL.ViewModel;

namespace TechnicalCalculatorTests
{
    [TestFixture]
    public class CalculatorControllerTest
    {
        [Test]
        public void SelectedOperation_InputArgument_SelectingOperation()
        {
            //Arrange
            var operands = new Operands(new Number() { Value=6}, new Number() { Value=4});
            var calculatoController = new CalculatorViewModel();

            //Act
            calculatoController.SelectedOperation("+", operands);
            var resultAddition = calculatoController.ResultNumber.Value;

            calculatoController.SelectedOperation("-", operands);
            var resultSubstraction = calculatoController.ResultNumber.Value;

            calculatoController.SelectedOperation("*", operands);
            var resultMultiply = calculatoController.ResultNumber.Value;

            calculatoController.SelectedOperation("/", operands);
            var resultDivision = calculatoController.ResultNumber.Value;

            calculatoController.SelectedOperation("%", operands);
            var resultDivisionReaminder = calculatoController.ResultNumber.Value;

            calculatoController.SelectedOperation("^", operands);
            var resultExponentiation = calculatoController.ResultNumber.Value;

            calculatoController.SelectedOperation("!", operands);
            var resultFactorial = calculatoController.ResultNumber.Value;

            //Assert
            Assert.AreEqual(10, resultAddition);
            Assert.AreEqual(2, resultSubstraction);
            Assert.AreEqual(24, resultMultiply);
            Assert.AreEqual(1.5, resultDivision);
            Assert.AreEqual(2, resultDivisionReaminder);
            Assert.AreEqual(1296, resultExponentiation);
            Assert.AreEqual(720, resultFactorial);
        }
    }
}

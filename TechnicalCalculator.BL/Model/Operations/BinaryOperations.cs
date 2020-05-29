using System;

namespace TechnicalCalculator.BL.Model.Operations
{
    public class BinaryOperations
    {
        /// <summary>
        /// Операция сложения.
        /// </summary>
        /// <param name="firstNumber"> Первый операнд </param>
        /// <param name="secondNumber"> Второй операнд </param>
        /// <returns> Результат сложения. </returns>
        public ResultNumber Addition(FirstNumber firstNumber, SecondNumber secondNumber) => (ResultNumber)(firstNumber + secondNumber);

        /// <summary>
        /// Операция вычитания.
        /// </summary>
        /// <param name="firstNumber"> Первый операнд. </param>
        /// <param name="secondNumber"> Второй операнд. </param>
        /// <returns> Результат вычитания. </returns>
        public ResultNumber Subsctraction(FirstNumber firstNumber, SecondNumber secondNumber) => (ResultNumber)(firstNumber - secondNumber);

        /// <summary>
        /// Операция умножения.
        /// </summary>
        /// <param name="firstNumber"> Первый операнд. </param>
        /// <param name="secondNumber"> Второй операнд. </param>
        /// <returns> Результат умножения. </returns>
        public ResultNumber Multiplication(FirstNumber firstNumber, SecondNumber secondNumber) => (ResultNumber)(firstNumber * secondNumber);

        /// <summary>
        /// Операция деления.
        /// </summary>
        /// <param name="firstNumber"> Первый операнд. </param>
        /// <param name="secondNumber"> Второй операнд. </param>
        /// <returns> Результат деления. </returns>
        public ResultNumber Division(FirstNumber firstNumber, SecondNumber secondNumber) => (ResultNumber)(firstNumber / secondNumber);
    }
}

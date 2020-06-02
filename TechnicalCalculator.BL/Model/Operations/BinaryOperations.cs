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
        public Number Addition(Number firstNumber, Number secondNumber) => firstNumber + secondNumber;

        /// <summary>
        /// Операция вычитания.
        /// </summary>
        /// <param name="firstNumber"> Первый операнд. </param>
        /// <param name="secondNumber"> Второй операнд. </param>
        /// <returns> Результат вычитания. </returns>
        public Number Subsctraction(Number firstNumber, Number secondNumber) => firstNumber - secondNumber;

        /// <summary>
        /// Операция умножения.
        /// </summary>
        /// <param name="firstNumber"> Первый операнд. </param>
        /// <param name="secondNumber"> Второй операнд. </param>
        /// <returns> Результат умножения. </returns>
        public Number Multiplication(Number firstNumber, Number secondNumber) => firstNumber * secondNumber;

        /// <summary>
        /// Операция деления.
        /// </summary>
        /// <param name="firstNumber"> Первый операнд. </param>
        /// <param name="secondNumber"> Второй операнд. </param>
        /// <returns> Результат деления. </returns>
        public Number Division(Number firstNumber, Number secondNumber) => firstNumber / secondNumber;

        /// <summary>
        /// Операция деления с остатком.
        /// </summary>
        /// <param name="firstNumber"> Первый операнд. </param>
        /// <param name="secondNumber"> Второй операнд. </param>
        /// <returns> Результат деления с остатком. </returns>
        public Number DivisionReaminder(Number firstNumber, Number secondNumber) => firstNumber % secondNumber;
    }
}

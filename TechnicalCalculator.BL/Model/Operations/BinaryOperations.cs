using System;

namespace TechnicalCalculator.BL.Model.Operations
{
    /// <summary>
    /// Бинарные операции.
    /// </summary>
    public class BinaryOperations
    {
        /// <summary>
        /// Операция сложения.
        /// </summary>
        /// <param name="firstNumber"> Первый операнд </param>
        /// <param name="secondNumber"> Второй операнд </param>
        /// <returns> Результат сложения. </returns>
        public static Number Addition(Number firstNumber, Number secondNumber) => firstNumber + secondNumber;

        /// <summary>
        /// Операция вычитания.
        /// </summary>
        /// <param name="firstNumber"> Первый операнд. </param>
        /// <param name="secondNumber"> Второй операнд. </param>
        /// <returns> Результат вычитания. </returns>
        public static Number Subsctraction(Number firstNumber, Number secondNumber) => firstNumber - secondNumber;

        /// <summary>
        /// Операция умножения.
        /// </summary>
        /// <param name="firstNumber"> Первый операнд. </param>
        /// <param name="secondNumber"> Второй операнд. </param>
        /// <returns> Результат умножения. </returns>
        public static Number Multiplication(Number firstNumber, Number secondNumber) => firstNumber * secondNumber;

        /// <summary>
        /// Операция деления.
        /// </summary>
        /// <param name="firstNumber"> Первый операнд. </param>
        /// <param name="secondNumber"> Второй операнд. </param>
        /// <returns> Результат деления. </returns>
        public static Number Division(Number firstNumber, Number secondNumber) => firstNumber / secondNumber;

        /// <summary>
        /// Операция деления с остатком.
        /// </summary>
        /// <param name="firstNumber"> Первый операнд. </param>
        /// <param name="secondNumber"> Второй операнд. </param>
        /// <returns> Результат деления с остатком. </returns>
        public static Number DivisionReaminder(Number firstNumber, Number secondNumber) => firstNumber % secondNumber;
    }
}

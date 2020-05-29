using System;


namespace TechnicalCalculator.BL.Model
{
    /// <summary>
    /// Операции.
    /// </summary>
    public class Operations
    {
        /// <summary>
        /// Операция сложения.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public ResultNumber Addition(FirstNumber firstNumber, SecondNumber secondNumber) => (ResultNumber)(firstNumber + secondNumber);

        /// <summary>
        /// Операция вычитания.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public ResultNumber Subsctraction(FirstNumber firstNumber, SecondNumber secondNumber) => (ResultNumber)(firstNumber - secondNumber);

        /// <summary>
        /// Операция умножения.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public ResultNumber Multiplication(FirstNumber firstNumber, SecondNumber secondNumber) => (ResultNumber)(firstNumber * secondNumber);

        /// <summary>
        /// Операция деления.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public ResultNumber Division(FirstNumber firstNumber, SecondNumber secondNumber) => (ResultNumber)(firstNumber / secondNumber);
    }
}

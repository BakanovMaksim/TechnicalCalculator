using System;

namespace TechnicalCalculator.BL.Model
{
    /// <summary>
    /// Операнды.
    /// </summary>
    public class Operands
    {
        /// <summary>
        /// Первое число.
        /// </summary>
        public FirstNumber FirstNumber { get; }

        /// <summary>
        /// Второе число.
        /// </summary>
        public SecondNumber SecondNumber { get; }

        /// <summary>
        /// Заполнение данных.
        /// </summary>
        /// <param name="firstNumber"> Первое число. </param>
        /// <param name="secondNumber"> Второе число. </param>
        public Operands(
            FirstNumber firstNumber,
            SecondNumber secondNumber)
        {
            if (firstNumber == null) throw new ArgumentNullException("Первое число не может быть пустым.", nameof(firstNumber));

            if (secondNumber == null) throw new ArgumentNullException("Второе число не может быть пустым.", nameof(secondNumber));

            FirstNumber = firstNumber;
            SecondNumber = secondNumber;
        }
    }
}

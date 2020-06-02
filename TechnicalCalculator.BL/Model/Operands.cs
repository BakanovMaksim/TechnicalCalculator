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
        public Number FirstNumber { get; }

        /// <summary>
        /// Второе число.
        /// </summary>
        public Number SecondNumber { get; }

        /// <summary>
        /// Заполнение данных.
        /// </summary>
        /// <param name="firstNumber"> Первое число. </param>
        /// <param name="secondNumber"> Второе число. </param>
        public Operands(
            Number firstNumber,
            Number secondNumber)
        {
            #region Проверка условий
            if (firstNumber == null) throw new ArgumentNullException("Первое число не может быть пустым.", nameof(firstNumber));

            if (secondNumber == null) throw new ArgumentNullException("Второе число не может быть пустым.", nameof(secondNumber));
            #endregion

            FirstNumber = firstNumber;
            SecondNumber = secondNumber;
        }
    }
}

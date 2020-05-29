using System;

namespace TechnicalCalculator.BL.Model
{
    /// <summary>
    /// Второе число.
    /// </summary>
    public class SecondNumber : Number
    {
        /// <summary>
        /// Заполнение данных.
        /// </summary>
        /// <param name="type"> Тип. </param>
        /// <param name="value"> Значение. </param>
        /// <param name="numberSystem"> Система счисления. </param>
        public SecondNumber(int value) : base(value) { }
    }
}

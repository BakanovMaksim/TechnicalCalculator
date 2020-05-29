using System;

namespace TechnicalCalculator.BL.Model
{
    /// <summary>
    /// Результат.
    /// </summary>
    public class ResultNumber : Number
    {
        /// <summary>
        /// Заполнение данных.
        /// </summary>
        /// <param name="type"> Тип. </param>
        /// <param name="value"> Значение. </param>
        /// <param name="numberSystem"> Система счисления. </param>
        public ResultNumber(int value) : base(value) { }
    }
}

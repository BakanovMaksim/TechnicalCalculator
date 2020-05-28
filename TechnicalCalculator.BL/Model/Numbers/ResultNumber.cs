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
        public ResultNumber(string type,int value,string numberSystem) : base(type, value, numberSystem) { }
    }
}

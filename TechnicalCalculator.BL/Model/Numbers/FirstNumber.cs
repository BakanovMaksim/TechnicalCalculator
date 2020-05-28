using System;

namespace TechnicalCalculator.BL.Model
{
    /// <summary>
    /// Первое число.
    /// </summary>
    public class FirstNumber : Number
    {
        /// <summary>
        /// Заполнение данных.
        /// </summary>
        /// <param name="type"> Тип. </param>
        /// <param name="value"> Значение. </param>
        /// <param name="numberSystem"> Система счисления. </param>
        public FirstNumber(string type,int value,string numberSystem) : base(type, value, numberSystem) { }
    }
}

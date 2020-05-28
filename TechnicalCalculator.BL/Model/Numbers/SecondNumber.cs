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
        public SecondNumber(string type,int value,string numberSystem) : base(type, value, numberSystem) { }
    }
}

using System;
using System.Reflection.Metadata.Ecma335;

namespace TechnicalCalculator.BL.Model
{
    /// <summary>
    /// Абстрактный класс для числа.
    /// </summary>
    public abstract class Number
    {
        /// <summary>
        /// Тип числа.
        /// </summary>
        public string Type { get; }

        /// <summary>
        /// Значение числа.
        /// </summary>
        public int Value { get; }

        /// <summary>
        /// Система счисления числа.
        /// </summary>
        public string NumberSystem { get; }

        /// <summary>
        /// Заполнение данных.
        /// </summary>
        /// <param name="type"> Тип. </param>
        /// <param name="value"> Значение. </param>
        /// <param name="numberSystem"> Система счисления. </param>
        public Number(int value)
        {
            if (value.GetType() != typeof(int)) throw new ArgumentException("Значение должно быть целым числом.", nameof(value));

            Type = value.GetType().ToString();
            Value = value;
        }

        public static Number operator +(Number firstNumber, Number secondNumber) => new ResultNumber(firstNumber.Value + secondNumber.Value);

        public static Number operator -(Number firstNumber, Number secondNumber) => new ResultNumber(firstNumber.Value - secondNumber.Value);

        public static Number operator *(Number firstNumber, Number secondNumber) => new ResultNumber(firstNumber.Value * secondNumber.Value);

        public static Number operator /(Number firstNumber, Number secondNumber) => new ResultNumber(firstNumber.Value / secondNumber.Value);

        public static Number operator %(Number firstNumber, Number secondNumber) => new ResultNumber(firstNumber.Value % secondNumber.Value);
    }
}

using System;

namespace TechnicalCalculator.BL.Model
{
    /// <summary>
    /// Абстрактный класс для числа.
    /// </summary>
    public class Number
    {
        /// <summary>
        /// Тип числа.
        /// </summary>
        public string Type { get; }

        /// <summary>
        /// Значение числа.
        /// </summary>
        public double Value { get; }

        /// <summary>
        /// Система счисления числа.
        /// </summary>
        public string NumberSystem { get; }

        /// <summary>
        /// Заполнение данных.
        /// </summary>
        /// <param name="value"> Значение. </param>
        /// <param name="numberSystem"> Система счисления. </param>
        public Number(double value)
        {
            if (value.GetType() != typeof(double)) throw new ArgumentException("Значение должно быть целым числом.", nameof(value));

            Type = value.GetType().ToString();
            Value = value;
        }

        public static Number operator +(Number firstNumber, Number secondNumber) => new Number(firstNumber.Value + secondNumber.Value);

        public static Number operator -(Number firstNumber, Number secondNumber) => new Number(firstNumber.Value - secondNumber.Value);

        public static Number operator *(Number firstNumber, Number secondNumber) => new Number(firstNumber.Value * secondNumber.Value);

        public static Number operator /(Number firstNumber, Number secondNumber) => new Number(firstNumber.Value / secondNumber.Value);

        public static Number operator %(Number firstNumber, Number secondNumber) => new Number(firstNumber.Value % secondNumber.Value);

        public static Number operator ^(Number firstNumber, Number secondNumber) => new Number(Math.Pow(firstNumber.Value, secondNumber.Value));

        public static Number operator !(Number number)
        {
            var temp = 1;

            for (int k = 2; k <= number.Value; k++)
                temp *= k;

            return new Number(temp);
        }
    }
}

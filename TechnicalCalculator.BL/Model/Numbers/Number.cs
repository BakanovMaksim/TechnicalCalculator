using System;

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
        public Number(
            string type,
            int value,
            string numberSystem)
        {
            if (string.IsNullOrWhiteSpace(type)) throw new ArgumentNullException("Тип не может быть пустым.", nameof(type));

            if (string.IsNullOrWhiteSpace(numberSystem)) new ArgumentNullException("Система счисления не может быть пустой.", nameof(numberSystem));

            Type = type;
            Value = value;
            NumberSystem = numberSystem;
        }

        public override string ToString() => $"{Value} - {NumberSystem}";
    }
}

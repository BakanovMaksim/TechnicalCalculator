using System;

namespace TechnicalCalculator.BL.Model.UnitMeasures
{
    /// <summary>
    /// Сантиметры.
    /// </summary>
    public class Centimetre : IUnitMeasure
    {
        /// <summary>
        /// Значение.
        /// </summary>
        public double Value { get; }

        /// <summary>
        /// Название единицы.
        /// </summary>
        public string TypeName { get; }

        /// <summary>
        /// Заполнение данных.
        /// </summary>
        /// <param name="value"> Значение. </param>
        public Centimetre(double value)
        {
            if (value < 0) throw new ArgumentException("Единица измерения (см) не может быть отрицательной.", nameof(value));

            Value = value;
            TypeName = "cm";
        }
    }
}

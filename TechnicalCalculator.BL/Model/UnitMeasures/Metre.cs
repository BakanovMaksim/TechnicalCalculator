using System;

namespace TechnicalCalculator.BL.Model.UnitMeasures
{
    /// <summary>
    /// Метры.
    /// </summary>
    public class Metre : IUnitMeasure
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
        public Metre(double value)
        {
            if (value < 0) throw new ArgumentException("Единица измерения (м) не может быть отрицательной.", nameof(value));

            Value = value;
            TypeName = "m";
        }
    }
}

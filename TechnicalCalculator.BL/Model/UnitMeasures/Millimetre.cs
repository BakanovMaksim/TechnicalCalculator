using System;

namespace TechnicalCalculator.BL.Model.UnitMeasures
{
    /// <summary>
    /// Миллиметры.
    /// </summary>
    public class Millimetre : IUnitMeasure
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
        public Millimetre(double value)
        {
            if (value < 0) throw new ArgumentException("Единица измерения (мм) не может быть отрицательной.", nameof(value));

            Value = value;
            TypeName = "mm";
        }
    }
}

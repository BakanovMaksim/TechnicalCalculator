using System;

namespace TechnicalCalculator.BL.Model.UnitMeasures
{
    /// <summary>
    /// Километры.
    /// </summary>
    public class Kilometre : IUnitMeasure
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
        public Kilometre(double value)
        {
            if (value < 0) throw new ArgumentException("Единица измерения (км) не может быть отрицательной.", nameof(value));

            Value = value;
            TypeName = "km";
        }
    }
}

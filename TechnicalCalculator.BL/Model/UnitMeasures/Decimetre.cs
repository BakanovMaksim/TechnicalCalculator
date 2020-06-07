using System;

namespace TechnicalCalculator.BL.Model.UnitMeasures
{
    /// <summary>
    /// Дециметры.
    /// </summary>
    public class Decimetre : IUnitMeasure
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
        public Decimetre(double value)
        {
            if (value < 0) throw new ArgumentException("Единица измерения (дм) не может быть отрицательной.", nameof(value));

            Value = value;
            TypeName = "dm";
        }
    }
}

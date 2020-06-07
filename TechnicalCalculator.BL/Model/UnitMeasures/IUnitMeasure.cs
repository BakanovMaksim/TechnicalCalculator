using System;

namespace TechnicalCalculator.BL.Model
{
    /// <summary>
    /// Интерфейс для единиц измерения.
    /// </summary>
    public interface IUnitMeasure
    {
        /// <summary>
        /// Значение.
        /// </summary>
        double Value { get; }

        /// <summary>
        /// Название единицы.
        /// </summary>
        string TypeName { get; }
    }
}

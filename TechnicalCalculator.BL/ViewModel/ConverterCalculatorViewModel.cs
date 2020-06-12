using System;
using TechnicalCalculator.BL.Models.UnitMeasures;

namespace TechnicalCalculator.BL.ViewModel
{
    /// <summary>
    /// Контроллер калькулятора конвертера.
    /// </summary>
    public class ConverterCalculatorViewModel
    {
        /// <summary>
        /// Изначальная единица измерения.
        /// </summary>
        public UnitMeasure InitialUnitMeasure { get; private set; }

        /// <summary>
        /// Единица измерения после конвертации.
        /// </summary>
        public UnitMeasure ConvertedUnitMeasure { get; private set; }

        /// <summary>
        /// Присвоение новой единицы измерения.
        /// </summary>
        /// <param name="initialUnitMeasure"> Изначальная единица измерения. </param>
        public void SetNewUnitMeasure(UnitMeasure initialUnitMeasure)
        {
            if (initialUnitMeasure == null) throw new ArgumentNullException("Единица измерения не может быть пустой.", nameof(initialUnitMeasure));

            InitialUnitMeasure = initialUnitMeasure;
        }

        /// <summary>
        /// Преобразование в желаемую единицу измерения.
        /// </summary>
        /// <param name="resultConverUnitMeasure"> Название желаемой единицы измерения. </param>
        public void ConverUnitMeasure(string resultConverUnitMeasure)
        {
            if (nameof(InitialUnitMeasure.TypeName) == "mm" && resultConverUnitMeasure == "cm") ConvertedUnitMeasure = new UnitMeasure() { Value = 1 / InitialUnitMeasure.Value };

            if (nameof(InitialUnitMeasure.TypeName) == "mm" && resultConverUnitMeasure == "dm") ConvertedUnitMeasure = new UnitMeasure() { Value = 10 / InitialUnitMeasure.Value };

            if (nameof(InitialUnitMeasure.TypeName) == "mm" && resultConverUnitMeasure == "m") ConvertedUnitMeasure = new UnitMeasure() { Value = 100 / InitialUnitMeasure.Value };

            if (nameof(InitialUnitMeasure.TypeName) == "mm" && resultConverUnitMeasure == "km") ConvertedUnitMeasure = new UnitMeasure() { Value = 1000000 / InitialUnitMeasure.Value };


            if (nameof(InitialUnitMeasure.TypeName) == "cm" && resultConverUnitMeasure == "mm") ConvertedUnitMeasure = new UnitMeasure() { Value = 10 * InitialUnitMeasure.Value };

            if (nameof(InitialUnitMeasure.TypeName) == "cm" && resultConverUnitMeasure == "dm") ConvertedUnitMeasure = new UnitMeasure() { Value = 1 / InitialUnitMeasure.Value };

            if (nameof(InitialUnitMeasure.TypeName) == "cm" && resultConverUnitMeasure == "m") ConvertedUnitMeasure = new UnitMeasure() { Value = 100 / InitialUnitMeasure.Value };

            if (nameof(InitialUnitMeasure.TypeName) == "cm" && resultConverUnitMeasure == "km") ConvertedUnitMeasure = new UnitMeasure() { Value = 100000 / InitialUnitMeasure.Value };


            if (nameof(InitialUnitMeasure.TypeName) == "dm" && resultConverUnitMeasure == "mm") ConvertedUnitMeasure = new UnitMeasure() { Value = 100 * InitialUnitMeasure.Value };

            if (nameof(InitialUnitMeasure.TypeName) == "dm" && resultConverUnitMeasure == "cm") ConvertedUnitMeasure = new UnitMeasure() { Value = 10 * InitialUnitMeasure.Value };

            if (nameof(InitialUnitMeasure.TypeName) == "dm" && resultConverUnitMeasure == "m") ConvertedUnitMeasure = new UnitMeasure() { Value = 1 / InitialUnitMeasure.Value };

            if (nameof(InitialUnitMeasure.TypeName) == "dm" && resultConverUnitMeasure == "m") ConvertedUnitMeasure = new UnitMeasure() { Value = 10000 / InitialUnitMeasure.Value };


            if (nameof(InitialUnitMeasure.TypeName) == "m" && resultConverUnitMeasure == "mm") ConvertedUnitMeasure = new UnitMeasure() { Value = 1000 * InitialUnitMeasure.Value };

            if (nameof(InitialUnitMeasure.TypeName) == "m" && resultConverUnitMeasure == "cm") ConvertedUnitMeasure = new UnitMeasure() { Value = 100 * InitialUnitMeasure.Value };

            if (nameof(InitialUnitMeasure.TypeName) == "m" && resultConverUnitMeasure == "dm") ConvertedUnitMeasure = new UnitMeasure() { Value = 10 * InitialUnitMeasure.Value };

            if (nameof(InitialUnitMeasure.TypeName) == "m" && resultConverUnitMeasure == "km") ConvertedUnitMeasure = new UnitMeasure() { Value = 1000 / InitialUnitMeasure.Value };


            if (nameof(InitialUnitMeasure.TypeName) == "km" && resultConverUnitMeasure == "mm") ConvertedUnitMeasure = new UnitMeasure() { Value = 1000000 * InitialUnitMeasure.Value };

            if (nameof(InitialUnitMeasure.TypeName) == "km" && resultConverUnitMeasure == "cm") ConvertedUnitMeasure = new UnitMeasure() { Value = 100000 * InitialUnitMeasure.Value };

            if (nameof(InitialUnitMeasure.TypeName) == "km" && resultConverUnitMeasure == "dm") ConvertedUnitMeasure = new UnitMeasure() { Value = 10000 * InitialUnitMeasure.Value };

            if (nameof(InitialUnitMeasure.TypeName) == "km" && resultConverUnitMeasure == "m") ConvertedUnitMeasure = new UnitMeasure() { Value = 1000 * InitialUnitMeasure.Value };
        }
    }
}

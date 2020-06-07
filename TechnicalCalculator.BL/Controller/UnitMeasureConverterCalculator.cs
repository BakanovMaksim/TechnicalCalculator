using System;
using TechnicalCalculator.BL.Model;
using TechnicalCalculator.BL.Model.UnitMeasures;

namespace TechnicalCalculator.BL.Controller
{
    /// <summary>
    /// Контроллер калькулятора конвертера.
    /// </summary>
    public class UnitMeasureConverterCalculator
    {
        /// <summary>
        /// Изначальная единица измерения.
        /// </summary>
        public IUnitMeasure InitialUnitMeasure { get; private set; }

        /// <summary>
        /// Единица измерения после конвертации.
        /// </summary>
        public IUnitMeasure ConvertedUnitMeasure { get; private set; }

        /// <summary>
        /// Присвоение новой единицы измерения.
        /// </summary>
        /// <param name="initialUnitMeasure"> Изначальная единица измерения. </param>
        public void SetNewUnitMeasure(IUnitMeasure initialUnitMeasure)
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
            if (InitialUnitMeasure.TypeName == "mm" && resultConverUnitMeasure == "cm") ConvertedUnitMeasure = new Centimetre(1 / InitialUnitMeasure.Value);

            if(InitialUnitMeasure.TypeName == "mm" && resultConverUnitMeasure == "dm") ConvertedUnitMeasure = new Decimetre(10 / InitialUnitMeasure.Value);

            if (InitialUnitMeasure.TypeName == "mm" && resultConverUnitMeasure == "m") ConvertedUnitMeasure = new Metre(100 / InitialUnitMeasure.Value);

            if (InitialUnitMeasure.TypeName == "mm" && resultConverUnitMeasure == "km") ConvertedUnitMeasure = new Kilometre(1000000 / InitialUnitMeasure.Value);


            if (InitialUnitMeasure.TypeName == "cm" && resultConverUnitMeasure == "mm") ConvertedUnitMeasure = new Millimetre(10 * InitialUnitMeasure.Value);

            if (InitialUnitMeasure.TypeName == "cm" && resultConverUnitMeasure == "dm") ConvertedUnitMeasure = new Decimetre(1 / InitialUnitMeasure.Value);

            if (InitialUnitMeasure.TypeName == "cm" && resultConverUnitMeasure == "m") ConvertedUnitMeasure = new Metre(100 / InitialUnitMeasure.Value);

            if (InitialUnitMeasure.TypeName == "cm" && resultConverUnitMeasure == "km") ConvertedUnitMeasure = new Kilometre(100000 / InitialUnitMeasure.Value);


            if (InitialUnitMeasure.TypeName == "dm" && resultConverUnitMeasure == "mm") ConvertedUnitMeasure = new Millimetre(100 * InitialUnitMeasure.Value);

            if (InitialUnitMeasure.TypeName == "dm" && resultConverUnitMeasure == "cm") ConvertedUnitMeasure = new Centimetre(10 * InitialUnitMeasure.Value);

            if (InitialUnitMeasure.TypeName == "dm" && resultConverUnitMeasure == "m") ConvertedUnitMeasure = new Metre(1 / InitialUnitMeasure.Value);
        }
    }
}

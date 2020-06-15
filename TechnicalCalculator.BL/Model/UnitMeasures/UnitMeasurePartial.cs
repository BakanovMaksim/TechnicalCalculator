using System;

namespace TechnicalCalculator.BL.Models.UnitMeasures
{
    public partial class UnitMeasure
    {
        private string _error;
        public string Error => _error;

        public string this[string column]
        {
            get
            {
                switch(column)
                {
                    case nameof(Value):
                        if (Value < 0) return "Единица измерения не может быть меньше 0";
                        break;
                    case nameof(TypeName):
                        break;
                }

                return string.Empty;
            }
        }
    }
}

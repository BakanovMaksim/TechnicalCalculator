using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TechnicalCalculator.BL.Models.UnitMeasures
{
    /// <summary>
    /// Единица измерения.
    /// </summary>
    public partial class UnitMeasure : INotifyPropertyChanged,IDataErrorInfo
    {
        private double _value;
        /// <summary>
        /// Значение.
        /// </summary>
        public double Value
        {
            get => _value;
            set
            {
                _value = value;
                OnPropertyChanged(nameof(Value));
            }
        }

        private UnitMeasureName _typeName;
        /// <summary>
        /// Название единицы измерения.
        /// </summary>
        public UnitMeasureName TypeName
        {
            get => _typeName;
            set
            {
                _typeName = value;
                OnPropertyChanged(nameof(TypeName));
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
    }
}

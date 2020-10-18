using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TechnicalCalculator.BL.Model
{
    /// <summary>
    /// Calculator.
    /// </summary>
    public class Calculator : INotifyPropertyChanged
    {
        #region Свойства
        /// <summary>
        /// The left operand.
        /// </summary
        public Number LeftNumber { get; }

        /// <summary>
        /// The right operand.
        /// </summary>
        public Number RightNumber { get; }

        /// <summary>
        /// Result.
        /// </summary>
        private Number _resultNumber;
        public Number ResultNumber
        {
            get => _resultNumber;
            set
            {
                if (value == null) throw new ArgumentNullException("The value cannot be empty.", nameof(value));
                _resultNumber = value;
                OnPropertyChanged(nameof(ResultNumber));
            }
        }

        /// <summary>
        /// Number in memory.
        /// </summary>
        private Number _memoryNumber;
        public Number MemoryNumber
        {
            get => _memoryNumber;
            set
            {
                _memoryNumber = value;
                OnPropertyChanged(nameof(MemoryNumber));
            }
        }

        /// <summary> 
        /// Expression.
        /// </summary>
        private string _expression = "0";
        public string Expression
        {
            get => _expression;
            set
            {
                _expression = value;
                OnPropertyChanged(nameof(Expression));
            }
        }
        #endregion

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
    }
}

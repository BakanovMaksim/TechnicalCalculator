using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TechnicalCalculator.BL.Model
{
    /// <summary>
    /// Калькулятор.
    /// </summary>
    public class Calculator : INotifyPropertyChanged
    {
        #region Свойства
        /// <summary>
        /// Первое операнд.
        /// </summary
        public Number FirstNumber { get; }

        /// <summary>
        /// Второй операнд.
        /// </summary>
        public Number SecondNumber { get; }

        /// <summary>
        /// Результат.
        /// </summary>
        private Number _resultNumber;
        public Number ResultNumber
        {
            get => _resultNumber;
            set
            {
                if (value == null) throw new ArgumentNullException("Значение не может быть пустым.", nameof(value));
                _resultNumber = value;
                OnPropertyChanged(nameof(ResultNumber));
            }
        }

        /// <summary>
        /// Число в памяти.
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
        /// Выражение.
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
        public void OnPropertyChanged([CallerMemberName]string prop = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
    }
}

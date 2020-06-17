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
        /// <summary>
        /// Первое операнд.
        /// </summary>
        private Number _firstNumber;
        public Number FirstNumber
        {
            get => _firstNumber;
            set
            {
                if (value == null) throw new ArgumentNullException("Значение не может быть пустым.", nameof(value));
                _firstNumber = value;
                OnPropertyChanged(nameof(FirstNumber));
            }
        }

        /// <summary>
        /// Второй операнд.
        /// </summary>
        private Number _secondNumber;
        public Number SecondNumber
        {
            get => _secondNumber;
            set
            {
                if (value == null) throw new ArgumentNullException("Значение не может быть пустым.", nameof(value));
                _secondNumber = value;
                OnPropertyChanged(nameof(SecondNumber));
            }
        }

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
                if (value == null) throw new ArgumentNullException("Значение не может быть пустым.", nameof(value));
                _memoryNumber = value;
                OnPropertyChanged(nameof(MemoryNumber));
            }
        }

        /// <summary>
        /// Значок операции.
        /// </summary>
        private string _operationIcon;
        public string OperationIcon
        {
            get => _operationIcon;
            set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentNullException("Значок операции не может быть пустым.", nameof(value));
                _operationIcon = value;
                OnPropertyChanged(nameof(OperationIcon));
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

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));

    }
}

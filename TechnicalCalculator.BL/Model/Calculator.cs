using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TechnicalCalculator.BL.Model
{
    public class Calculator : INotifyPropertyChanged
    {
        private Number _firstNumber;
        public Number FirstNumber
        {
            get => _firstNumber;
            set
            {
                _firstNumber = value;
                OnPropertyChanged(nameof(FirstNumber));
            }
        }

        private Number _secondNumber;
        public Number SecondNumber
        {
            get => _secondNumber;
            set
            {
                _secondNumber = value;
                OnPropertyChanged(nameof(SecondNumber));
            }
        }

        private Number _resultNumber;
        public Number ResultNumber
        {
            get => _resultNumber;
            set
            {
                _resultNumber = value;
                OnPropertyChanged(nameof(ResultNumber));
            }
        }

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

        private string _operationIcon;
        public string OperationIcon
        {
            get => _operationIcon;
            set
            {
                _operationIcon = value;
                OnPropertyChanged(nameof(OperationIcon));
            }
        }

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

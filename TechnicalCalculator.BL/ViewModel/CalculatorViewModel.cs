using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using TechnicalCalculator.BL.Model;

namespace TechnicalCalculator.BL.ViewModel
{
    public class CalculatorViewModel : INotifyPropertyChanged
    {
        #region Свойства
        /// <summary>
        /// Операции.
        /// </summary>
        public Operation Operations { get; }

        private Calculator _calculator;
        public Calculator Calculator
        {
            get => _calculator;
            set
            {
                _calculator = value;
                OnPropertyChanged(nameof(Calculator));
            }
        }
        #endregion

        public CalculatorViewModel()
        {
            Operations = new Operation();
        }

        /// <summary>
        /// Выбор и выполнение операции.
        /// </summary>
        /// <param name="operation"> Операция. </param>
        /// <param name="operands"> Операнды. </param>
        public void SelectedOperation()
        {
            switch (Calculator.OperationIcon)
            {
                case "+":
                    Calculator.ResultNumber = Operations.BinaryOperations.Addition(Calculator.FirstNumber, Calculator.SecondNumber);
                    break;
                case "-":
                    Calculator.ResultNumber = Operations.BinaryOperations.Subsctraction(Calculator.FirstNumber, Calculator.SecondNumber);
                    break;
                case "*":
                    Calculator.ResultNumber = Operations.BinaryOperations.Multiplication(Calculator.FirstNumber, Calculator.SecondNumber);
                    break;
                case "/":
                    Calculator.ResultNumber = Operations.BinaryOperations.Division(Calculator.FirstNumber, Calculator.SecondNumber);
                    break;
                case "%":
                    Calculator.ResultNumber = Operations.BinaryOperations.DivisionReaminder(Calculator.FirstNumber, Calculator.SecondNumber);
                    break;
                case "^":
                    Calculator.ResultNumber = Operations.UnaryOperations.Exponentiation(Calculator.FirstNumber, Calculator.SecondNumber);
                    break;
                case "!":
                    Calculator.ResultNumber = Operations.UnaryOperations.Factorial(Calculator.FirstNumber);
                    break;
            }
        }

        private RelayCommand _saveMemoryCommand;
        public RelayCommand SaveMemoryCommand
        {
            get => _saveMemoryCommand ?? (_saveMemoryCommand = new RelayCommand(obj => { Calculator.MemoryNumber = Calculator.ResultNumber; }));
        }

        private RelayCommand _clearMemoryCommand;
        public RelayCommand ClearMemoryCommand
        {
            get => _clearMemoryCommand ?? (_clearMemoryCommand = new RelayCommand(obj => { Calculator.MemoryNumber = null; }));
        }

        private RelayCommand _addMemoryCommand;
        public RelayCommand AddMemoryCommand
        {
            get => _addMemoryCommand ?? (_addMemoryCommand = new RelayCommand(obj => { Calculator.ResultNumber += Calculator.MemoryNumber; }));
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));

    }
}

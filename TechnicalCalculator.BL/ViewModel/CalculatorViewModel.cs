using System;
using System.Linq;
using System.Collections.Generic;
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
            Calculator = new Calculator();
        }

        /// <summary>
        /// Выбор и выполнение операции.
        /// </summary>
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

            Calculator.Expression = Calculator.ResultNumber?.Value.ToString();
        }

        private void CompletionData()
        {
            var itemsFirstNumber = Calculator.Expression.TakeWhile(p => char.IsDigit(p));
            var itemsSecondNumber = Calculator.Expression.SkipWhile(p => char.IsDigit(p) || p == '.').SkipWhile(p => !char.IsDigit(p)).TakeWhile(p => char.IsDigit(p) || p == '.');
            var itemsOperation = Calculator.Expression.SkipWhile(p => char.IsDigit(p) || p == '.').TakeWhile(p => !char.IsDigit(p));

            Calculator.FirstNumber = new Number() { Value = double.Parse(ParseString(itemsFirstNumber)) };
            Calculator.SecondNumber = new Number() { Value = double.Parse(ParseString(itemsSecondNumber)) };
            Calculator.OperationIcon = ParseString(itemsOperation);

            SelectedOperation();
        }

        private string ParseString(IEnumerable<char> items)
        {
            var str = "";

            foreach (var item in items)
                str += item;

            return str;
        }

        private RelayCommand _resultCommand;
        public RelayCommand ResultCommand
        {
            get => _resultCommand ?? (_resultCommand = new RelayCommand(obj => { CompletionData(); }));
        }

        private RelayCommand _saveCommand;
        public RelayCommand SaveCommand
        {
            get => _saveCommand ?? (_saveCommand = new RelayCommand(obj => { Calculator.Expression = "0"; }));
        }

        private RelayCommand _saveMemoryCommand;
        public RelayCommand SaveMemoryCommand
        {
            get => _saveMemoryCommand ?? (_saveMemoryCommand = new RelayCommand(obj => { Calculator.MemoryNumber = Calculator.ResultNumber; }));
        }

        private RelayCommand _enterMemoryCommand;
        public RelayCommand EnterMemoryCommand
        {
            get => _enterMemoryCommand ?? (_enterMemoryCommand = new RelayCommand(obj => { Calculator.Expression += Calculator.MemoryNumber.Value.ToString(); }));
        }

        private RelayCommand _clearMemoryCommand;
        public RelayCommand ClearMemoryCommand
        {
            get => _clearMemoryCommand ?? (_clearMemoryCommand = new RelayCommand(obj => { Calculator.MemoryNumber = null; }));
        }

        private RelayCommand _addMemoryCommand;
        public RelayCommand AddMemoryCommand
        {
            get => _addMemoryCommand ?? (_addMemoryCommand = new RelayCommand(obj => { Calculator.MemoryNumber += Calculator.ResultNumber; }));
        }

        private RelayCommand _subMemoryCommand;
        public RelayCommand SubMemoryCommand
        {
            get => _subMemoryCommand ?? (_subMemoryCommand = new RelayCommand(obj => { Calculator.MemoryNumber -= Calculator.ResultNumber; }));
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));

    }
}

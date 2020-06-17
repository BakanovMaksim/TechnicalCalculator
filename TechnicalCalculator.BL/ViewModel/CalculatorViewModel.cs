using System;
using System.Linq;
using System.Collections.Generic;
using TechnicalCalculator.BL.Model;

namespace TechnicalCalculator.BL.ViewModel
{
    /// <summary>
    /// Логика калькулятора.
    /// </summary>
    public class CalculatorViewModel
    {
        #region Свойства
        /// <summary>
        /// Операции.
        /// </summary>
        public Operation Operations { get; }

        /// <summary>
        /// Калькулятор.
        /// </summary>
        public Calculator Calculator { get; }
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

        /// <summary>
        /// Сбор данных из выражения.
        /// </summary>
        private void CompletionData()
        {
            var itemsOperation = Calculator.Expression.SkipWhile(p => char.IsDigit(p) || p == '.').TakeWhile(p => !char.IsDigit(p));
            var itemsFirstNumber = Calculator.Expression.TakeWhile(p => char.IsDigit(p) || p == '.');
            var itemsSecondNumber = Calculator.Expression.SkipWhile(p => char.IsDigit(p) || p == '.').SkipWhile(p => !char.IsDigit(p)).TakeWhile(p => char.IsDigit(p) || p == '.');

            Calculator.FirstNumber = new Number() { Value = double.Parse(ParseString(itemsFirstNumber)) };
            if(itemsSecondNumber.Count() > 0) Calculator.SecondNumber = new Number() { Value = double.Parse(ParseString(itemsSecondNumber)) };
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

        /// <summary>
        /// Команда вывода результата.
        /// </summary>
        private RelayCommand _resultCommand;
        public RelayCommand ResultCommand
        {
            get => _resultCommand ?? (_resultCommand = new RelayCommand(obj => { CompletionData(); }));
        }

        /// <summary>
        /// Команда очистки выражения.
        /// </summary>
        private RelayCommand _clearCommand;
        public RelayCommand ClearCommand
        {
            get => _clearCommand ?? (_clearCommand = new RelayCommand(obj => { Calculator.Expression = "0"; }));
        }

        /// <summary>
        /// Команда сохранения результата в памяти.
        /// </summary>
        private RelayCommand _saveMemoryCommand;
        public RelayCommand SaveMemoryCommand
        {
            get => _saveMemoryCommand ?? (_saveMemoryCommand = new RelayCommand(obj => { Calculator.MemoryNumber = Calculator.ResultNumber; }));
        }

        /// <summary>
        /// Команда вывода числа в памяти на экран.
        /// </summary>
        private RelayCommand _enterMemoryCommand;
        public RelayCommand EnterMemoryCommand
        {
            get => _enterMemoryCommand ?? (_enterMemoryCommand = new RelayCommand(obj => { Calculator.Expression += Calculator.MemoryNumber.Value.ToString(); }));
        }

        /// <summary>
        /// Команда очистки числа в памяти.
        /// </summary>
        private RelayCommand _clearMemoryCommand;
        public RelayCommand ClearMemoryCommand
        {
            get => _clearMemoryCommand ?? (_clearMemoryCommand = new RelayCommand(obj => { Calculator.MemoryNumber = null; }));
        }

        /// <summary>
        /// Команда сложения числа в памяти с результатом.
        /// </summary>
        private RelayCommand _addMemoryCommand;
        public RelayCommand AddMemoryCommand
        {
            get => _addMemoryCommand ?? (_addMemoryCommand = new RelayCommand(obj => { Calculator.MemoryNumber += Calculator.ResultNumber; }));
        }

        /// <summary>
        /// Команда вычитания числа в памяти с результатом.
        /// </summary>
        private RelayCommand _subMemoryCommand;
        public RelayCommand SubMemoryCommand
        {
            get => _subMemoryCommand ?? (_subMemoryCommand = new RelayCommand(obj => { Calculator.MemoryNumber -= Calculator.ResultNumber; }));
        }
    }
}

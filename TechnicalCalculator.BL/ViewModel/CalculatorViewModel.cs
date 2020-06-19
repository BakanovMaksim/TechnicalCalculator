using System;
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
        /// Калькулятор.
        /// </summary>
        public Calculator Calculator { get; }

        /// <summary>
        /// Выражение преобразованное в обратную Польскую нотацию.
        /// </summary>
        public string ReverseExpression { get; private set; }
        #endregion

        public CalculatorViewModel()
        {
            Calculator = new Calculator();
        }

        /// <summary>
        /// Сбор данных и вычисление выражения.
        /// </summary>
        private void CompletionData()
        {
            ReverseExpression = ReversePolishNotation.GetExpression(Calculator.Expression);

            Calculator.ResultNumber = ReversePolishNotation.Counting(ReverseExpression,Calculator.FirstNumber,Calculator.SecondNumber);

            Calculator.Expression = Calculator.ResultNumber?.Value.ToString();
        }

        #region Команды
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
        #endregion
    }
}

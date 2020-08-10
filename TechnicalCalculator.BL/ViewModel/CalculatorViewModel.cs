using TechnicalCalculator.BL.Model;

namespace TechnicalCalculator.BL.ViewModel
{
    /// <summary>
    /// Logic of the calculator.
    /// </summary>
    public class CalculatorViewModel
    {
        #region Properties
        /// <summary>
        /// Calculator.
        /// </summary>
        public Calculator Calculator { get; }

        /// <summary>
        /// The expression is converted to reverse Polish notation.
        /// </summary>
        public string ReverseExpression { get; private set; }
        #endregion

        public CalculatorViewModel()
        {
            Calculator = new Calculator();
        }

        /// <summary>
        /// Data collection and expression calculation.
        /// </summary>
        private void CompletionData()
        {
            ReverseExpression = ReversePolishNotation.GetExpression(Calculator.Expression);

            Calculator.ResultNumber = ReversePolishNotation.Counting(ReverseExpression, Calculator.FirstNumber, Calculator.SecondNumber);

            Calculator.Expression = Calculator.ResultNumber?.Value.ToString();
        }

        #region Commands
        /// <summary>
        /// Output result command.
        /// </summary>
        private RelayCommand _resultCommand;
        public RelayCommand ResultCommand
        {
            get => _resultCommand ?? (_resultCommand = new RelayCommand(obj => { CompletionData(); }));
        }

        /// <summary>
        /// Command to clear the expression.
        /// </summary>
        private RelayCommand _clearCommand;
        public RelayCommand ClearCommand
        {
            get => _clearCommand ?? (_clearCommand = new RelayCommand(obj => { Calculator.Expression = "0"; }));
        }

        /// <summary>
        /// Command to save the result in memory.
        /// </summary>
        private RelayCommand _saveMemoryCommand;
        public RelayCommand SaveMemoryCommand
        {
            get => _saveMemoryCommand ?? (_saveMemoryCommand = new RelayCommand(obj => { Calculator.MemoryNumber = Calculator.ResultNumber; }));
        }

        /// <summary>
        /// Command to display a number in memory on the screen.
        /// </summary>
        private RelayCommand _enterMemoryCommand;
        public RelayCommand EnterMemoryCommand
        {
            get => _enterMemoryCommand ?? (_enterMemoryCommand = new RelayCommand(obj => { Calculator.Expression += Calculator.MemoryNumber.Value.ToString(); }));
        }

        /// <summary>
        /// Command to clear a number in memory.
        /// </summary>
        private RelayCommand _clearMemoryCommand;
        public RelayCommand ClearMemoryCommand
        {
            get => _clearMemoryCommand ?? (_clearMemoryCommand = new RelayCommand(obj => { Calculator.MemoryNumber = null; }));
        }

        /// <summary>
        /// Command to add a number in memory with the result.
        /// </summary>
        private RelayCommand _addMemoryCommand;
        public RelayCommand AddMemoryCommand
        {
            get => _addMemoryCommand ?? (_addMemoryCommand = new RelayCommand(obj => { Calculator.MemoryNumber += Calculator.ResultNumber; }));
        }

        /// <summary>
        /// Command to subtract a number in memory with the result.
        /// </summary>
        private RelayCommand _subMemoryCommand;
        public RelayCommand SubMemoryCommand
        {
            get => _subMemoryCommand ?? (_subMemoryCommand = new RelayCommand(obj => { Calculator.MemoryNumber -= Calculator.ResultNumber; }));
        }
        #endregion
    }
}

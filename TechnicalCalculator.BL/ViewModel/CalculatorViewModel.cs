using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using TechnicalCalculator.BL.Model;

namespace TechnicalCalculator.BL.Controller
{
    public class CalculatorViewModel : INotifyPropertyChanged
    {
        #region Свойства
        /// <summary>
        /// Операнды.
        /// </summary>
        public Operands Operands { get; private set; }

        /// <summary>
        /// Операции.
        /// </summary>
        public Operation Operations { get; }

        private Number _resultNumber;
        /// <summary>
        /// Результат.
        /// </summary>
        public Number ResultNumber
        {
            get => _resultNumber;
            set
            {
                _resultNumber = value;
                OnPropertyChanged(nameof(ResultNumber));
            }
        }
        #endregion

        public CalculatorViewModel()
        {
            Operations = new Operation();
            ResultNumber = new Number() { Value = 5 };
        }

        /// <summary>
        /// Выбор и выполнение операции.
        /// </summary>
        /// <param name="operation"> Операция. </param>
        /// <param name="operands"> Операнды. </param>
        public void SelectedOperation(string operation, Operands operands)
        {
            #region Проверка условий
            if (string.IsNullOrWhiteSpace(operation)) throw new ArgumentNullException("Операция не может быть пустой.", nameof(operation));

            if (operands == null) throw new ArgumentNullException("Операнды не могут быть пустыми.", nameof(operands));
            #endregion

            Operands = operands;

            switch (operation)
            {
                case "+":
                    ResultNumber = Operations.BinaryOperations.Addition(operands.FirstNumber, operands.SecondNumber);
                    break;
                case "-":
                    ResultNumber = Operations.BinaryOperations.Subsctraction(operands.FirstNumber, operands.SecondNumber);
                    break;
                case "*":
                    ResultNumber = Operations.BinaryOperations.Multiplication(operands.FirstNumber, operands.SecondNumber);
                    break;
                case "/":
                    ResultNumber = Operations.BinaryOperations.Division(operands.FirstNumber, operands.SecondNumber);
                    break;
                case "%":
                    ResultNumber = Operations.BinaryOperations.DivisionReaminder(operands.FirstNumber, operands.SecondNumber);
                    break;
                case "^":
                    ResultNumber = Operations.UnaryOperations.Exponentiation(operands.FirstNumber, operands.SecondNumber);
                    break;
                case "!":
                    ResultNumber = Operations.UnaryOperations.Factorial(operands.FirstNumber);
                    break;
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));

    }
}

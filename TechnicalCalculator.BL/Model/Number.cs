using System.ComponentModel;
using System.Runtime.CompilerServices;

using TechnicalCalculator.BL.Model.Operations;

namespace TechnicalCalculator.BL.Model
{
    /// <summary>
    /// Base class for a number.
    /// </summary>
    public class Number : INotifyPropertyChanged
    {
        /// <summary>
        /// Type of number.
        /// </summary>
        private string _type;
        public string Type
        {
            get => _type;
            set
            {
                _type = value;
                OnPropertyChanged(nameof(Type));
            }
        }

        /// <summary>
        /// Value of number.
        /// </summary>
        private double _value;
        public double Value
        {
            get => _value;
            set
            {
                _value = value;
                OnPropertyChanged(nameof(Value));
            }
        }

        public static Number operator +(Number leftNumber, Number rightNumber) => OperationsHelper.Addition(leftNumber, rightNumber);

        public static Number operator -(Number leftNumber, Number rightNumber) => OperationsHelper.Substraction(leftNumber, rightNumber);

        public static Number operator *(Number leftNumber, Number rightNumber) => OperationsHelper.Multiplication(leftNumber, rightNumber);

        public static Number operator /(Number leftNumber, Number rightNumber) => OperationsHelper.Division(leftNumber, rightNumber);

        public static Number operator %(Number leftNumber, Number rightNumber) => OperationsHelper.DivisionReaminder(leftNumber, rightNumber);

        public static Number operator ^(Number leftNumber, Number rightNumber) => OperationsHelper.Exponentiation(leftNumber, rightNumber);

        public static Number operator !(Number number) => OperationsHelper.Factorial(number);


        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
    }
}

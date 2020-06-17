using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TechnicalCalculator.BL.Model
{
    /// <summary>
    /// Базовый класс для числа.
    /// </summary>
    public class Number : INotifyPropertyChanged
    {
        /// <summary>
        /// Тип числа.
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
        /// Значение числа.
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

        public static Number operator +(Number firstNumber, Number secondNumber) => new Number() { Value = firstNumber.Value + secondNumber.Value };

        public static Number operator -(Number firstNumber, Number secondNumber) => new Number() { Value = firstNumber.Value - secondNumber.Value };

        public static Number operator *(Number firstNumber, Number secondNumber) => new Number() { Value = firstNumber.Value * secondNumber.Value };

        public static Number operator /(Number firstNumber, Number secondNumber) => new Number() { Value = firstNumber.Value / secondNumber.Value };

        public static Number operator %(Number firstNumber, Number secondNumber) => new Number() { Value = firstNumber.Value % secondNumber.Value };

        public static Number operator ^(Number firstNumber, Number secondNumber) => new Number() { Value = Math.Pow(firstNumber.Value, secondNumber.Value) };

        public static Number operator !(Number number)
        {
            var temp = 1;

            for (int k = 2; k <= number.Value; k++)
                temp *= k;

            return new Number() { Value = temp };
        }


        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
    }
}

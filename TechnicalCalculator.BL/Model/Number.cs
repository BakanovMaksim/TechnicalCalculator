using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TechnicalCalculator.BL.Model
{
    /// <summary>
    /// Абстрактный класс для числа.
    /// </summary>
    public class Number : INotifyPropertyChanged
    {
        private string _type;
        /// <summary>
        /// Тип числа.
        /// </summary>
        public string Type
        {
            get => _type;
            set
            {
                _type = value;
                OnPropertyChanged(nameof(Type));
            }
        }

        private double _value;
        /// <summary>
        /// Значение числа.
        /// </summary>
        public double Value
        {
            get => _value;
            set
            {
                _value = value;
                OnPropertyChanged(nameof(Value));
            }
        }

        private string _numberSystem;
        /// <summary>
        /// Система счисления числа.
        /// </summary>
        public string NumberSystem
        {
            get => _numberSystem;
            set
            {
                _numberSystem = value;
                OnPropertyChanged(nameof(NumberSystem));
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

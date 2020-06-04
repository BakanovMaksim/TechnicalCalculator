using System;

namespace TechnicalCalculator.BL.Model.Operations
{
    /// <summary>
    /// Унарные операции.
    /// </summary>
    public class UnaryOperations
    {
        /// <summary>
        /// Возведение в степень.
        /// </summary>
        /// <param name="firstNumber"> Число </param>
        /// <param name="secondNumber"> Степень. </param>
        /// <returns> Результат возведения в степень. </returns>
        public Number Exponentiation(Number firstNumber, Number secondNumber) => firstNumber ^ secondNumber;

        /// <summary>
        /// Факториал числа.
        /// </summary>
        /// <param name="number"> Число. </param>
        /// <returns> Результат вычисления факториала. </returns>  
        public Number Factorial(Number number) => !number;                      //TODO: Переделать в контроллере,чтобы принимался один аргумент, а не два.
    }
}

using System;


namespace TechnicalCalculator.BL.Model
{
    /// <summary>
    /// Операции.
    /// </summary>
    public class Operations
    {
        /// <summary>
        /// Операция сложения.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public int Addition(int x, int y) => x + y;

        /// <summary>
        /// Операция вычитания.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public int Subsctraction(int x, int y) => x - y;

        /// <summary>
        /// Операция умножения.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public int Multiplication(int x,int y) => x * y;

        /// <summary>
        /// Операция деления.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public int Division(int x,int y) => x / y;
    }
}

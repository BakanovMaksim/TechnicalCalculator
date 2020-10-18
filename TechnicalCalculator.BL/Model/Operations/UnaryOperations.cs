namespace TechnicalCalculator.BL.Model.Operations
{
    /// <summary>
    /// Unary operation.
    /// </summary>
    public class UnaryOperations
    {
        /// <summary>
        /// Exponentiation.
        /// </summary>
        /// <param name="number"> Number. </param>
        /// <param name="degree"> Degree. </param>
        /// <returns> The result of the exponentiation. </returns>
        public static Number Exponentiation(Number number, Number degree) => number ^ degree;

        /// <summary>
        /// Factorial of the number.
        /// </summary>
        /// <param name="number"> Number. </param>
        /// <returns> Result of calculating the factorial. </returns>  
        public static Number Factorial(Number number) => !number;
    }
}

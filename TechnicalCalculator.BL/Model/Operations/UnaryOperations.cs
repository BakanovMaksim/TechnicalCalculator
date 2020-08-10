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
        /// <param name="firstNumber"> Number. </param>
        /// <param name="secondNumber"> Degree. </param>
        /// <returns> The result of the exponentiation. </returns>
        public static Number Exponentiation(Number firstNumber, Number secondNumber) => firstNumber ^ secondNumber;

        /// <summary>
        /// Factorial of the number.
        /// </summary>
        /// <param name="number"> Number. </param>
        /// <returns> Result of calculating the factorial. </returns>  
        public static Number Factorial(Number number) => !number;
    }
}

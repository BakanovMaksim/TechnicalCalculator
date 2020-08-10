namespace TechnicalCalculator.BL.Model.Operations
{
    /// <summary>
    /// Binary operation.
    /// </summary>
    public class BinaryOperations
    {
        /// <summary>
        /// Addition operation.
        /// </summary>
        /// <param name="firstNumber"> The first operand. </param>
        /// <param name="secondNumber"> The second operand. </param>
        /// <returns> The result of addition. </returns>
        public static Number Addition(Number firstNumber, Number secondNumber) => firstNumber + secondNumber;

        /// <summary>
        /// The operation of subtraction.
        /// </summary>
        /// <param name="firstNumber"> The first operand. </param>
        /// <param name="secondNumber"> The second operand. </param>
        /// <returns> The result of the subtraction. </returns>
        public static Number Subsctraction(Number firstNumber, Number secondNumber) => firstNumber - secondNumber;

        /// <summary>
        /// Multiplication operation.
        /// </summary>
        /// <param name="firstNumber"> The first operand. </param>
        /// <param name="secondNumber"> The second operand. </param>
        /// <returns> The result of the multiplication. </returns>
        public static Number Multiplication(Number firstNumber, Number secondNumber) => firstNumber * secondNumber;

        /// <summary>
        /// Division operation.
        /// </summary>
        /// <param name="firstNumber"> The first operand. </param>
        /// <param name="secondNumber"> The second operand. </param>
        /// <returns> The result of the division. </returns>
        public static Number Division(Number firstNumber, Number secondNumber) => firstNumber / secondNumber;

        /// <summary>
        /// Division operation with the remainder.
        /// </summary>
        /// <param name="firstNumber"> The first operand. </param>
        /// <param name="secondNumber"> The second operand. </param>
        /// <returns> Result of division with the remainder. </returns>
        public static Number DivisionReaminder(Number firstNumber, Number secondNumber) => firstNumber % secondNumber;
    }
}

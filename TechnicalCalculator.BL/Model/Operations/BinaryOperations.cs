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
        /// <param name="leftNumber"> The left operand. </param>
        /// <param name="rightNumber"> The right operand. </param>
        /// <returns> The result of addition. </returns>
        public static Number Addition(Number leftNumber, Number rightNumber) => leftNumber + rightNumber;

        /// <summary>
        /// The operation of subtraction.
        /// </summary>
        /// <param name="leftNumber"> The left operand. </param>
        /// <param name="rightNumber"> The right operand. </param>
        /// <returns> The result of the subtraction. </returns>
        public static Number Subsctraction(Number leftNumber, Number rightNumber) => leftNumber - rightNumber;

        /// <summary>
        /// Multiplication operation.
        /// </summary>
        /// <param name="leftNumber"> The left operand. </param>
        /// <param name="rightNumber"> The right operand. </param>
        /// <returns> The result of the multiplication. </returns>
        public static Number Multiplication(Number leftNumber, Number rightNumber) => leftNumber * rightNumber;

        /// <summary>
        /// Division operation.
        /// </summary>
        /// <param name="leftNumber"> The left operand. </param>
        /// <param name="rightNumber"> The right operand. </param>
        /// <returns> The result of the division. </returns>
        public static Number Division(Number leftNumber, Number rightNumber) => leftNumber / rightNumber;

        /// <summary>
        /// Division operation with the remainder.
        /// </summary>
        /// <param name="leftNumber"> The left operand. </param>
        /// <param name="rightNumber"> The right operand. </param>
        /// <returns> Result of division with the remainder. </returns>
        public static Number DivisionReaminder(Number leftNumber, Number rightNumber) => leftNumber % rightNumber;
    }
}

using System;

namespace TechnicalCalculator.BL.Model.Operations
{
    public class OperationsHelper
    {
        public static Number Addition(Number leftNumber, Number rightNumber)
        {
            var result = leftNumber.Value + rightNumber.Value;
            return new Number { Value = result };
        }

        public static Number Substraction(Number leftNumber, Number rightNumber)
        {
            var result = leftNumber.Value - rightNumber.Value;
            return new Number { Value = result };
        }

        public static Number Multiplication(Number leftNumber, Number rightNumber)
        {
            var result = leftNumber.Value * rightNumber.Value;
            return new Number { Value = result };
        }

        public static Number Division(Number leftNumber, Number rightNumber)
        {
            var result = leftNumber.Value / rightNumber.Value;
            return new Number { Value = result };
        }

        public static Number DivisionReaminder(Number leftNumber, Number rightNumber)
        {
            var result = leftNumber.Value % rightNumber.Value;
            return new Number { Value = result };
        }

        public static Number Exponentiation(Number leftNumber, Number rightNumber)
        {
            var result = Math.Pow(leftNumber.Value, rightNumber.Value);
            return new Number { Value = result };
        }

        public static Number Factorial(Number number)
        {
            var temp = 1;

            for (int k = 2; k <= number.Value; k++)
            {
                temp *= k;
            }

            return new Number() { Value = temp };
        }
    }
}

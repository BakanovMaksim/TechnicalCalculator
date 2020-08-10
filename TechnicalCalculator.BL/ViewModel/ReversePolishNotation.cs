using System;
using System.Collections.Generic;
using System.Globalization;
using TechnicalCalculator.BL.Model;
using TechnicalCalculator.BL.Model.Operations;

namespace TechnicalCalculator.BL.ViewModel
{
    /// <summary>
    /// Reverse Polish notation algorithm.
    /// </summary>
    public class ReversePolishNotation
    {
        /// <summary>
        /// Converting an expression to reverse Polish.
        /// </summary>
        /// <param name="inputExpression"> Input expression. </param>
        /// <returns> Expression of reverse Polish notation. </returns>
        public static string GetExpression(string inputExpression)
        {
            if (string.IsNullOrWhiteSpace(inputExpression)) throw new ArgumentNullException("The input string cannot be empty.", nameof(inputExpression));

            var outputExpression = string.Empty;
            var operStack = new Stack<char>();

            for (int i = 0; i < inputExpression.Length; i++)
            {
                if (IsDelimeter(inputExpression[i]))
                    continue;

                if (char.IsDigit(inputExpression[i]))
                {
                    while (!IsDelimeter(inputExpression[i]) && !IsOperator(inputExpression[i]))
                    {
                        outputExpression += inputExpression[i];
                        i++;

                        if (i == inputExpression.Length) break;
                    }

                    outputExpression += " ";
                    i--;
                }

                if (IsOperator(inputExpression[i]))
                {
                    if (inputExpression[i] == '(')
                        operStack.Push(inputExpression[i]);
                    else if (inputExpression[i] == ')')
                    {
                        char s = operStack.Pop();

                        while (s != '(')
                        {
                            outputExpression += s.ToString() + ' ';
                            s = operStack.Pop();
                        }
                    }
                    else
                    {
                        if (operStack.Count > 0)
                            if (CheckedPriority(inputExpression[i]) <= CheckedPriority(operStack.Peek()))
                                outputExpression += operStack.Pop().ToString() + " ";

                        operStack.Push(char.Parse(inputExpression[i].ToString()));
                    }
                }
            }

            while (operStack.Count > 0)
                outputExpression += operStack.Pop() + " ";

            return outputExpression;
        }

        /// <summary>
        /// The calculation of the converted expression.
        /// </summary>
        /// <param name="inputExpression"> Input the converted expression. </param>
        /// <param name="firstNumber"> The first number. </param>
        /// <param name="secondNumber"> The second number. </param>
        /// <returns> Result of calculating the expression. </returns>
        public static Number Counting(string inputExpression, Number firstNumber, Number secondNumber)
        {
            if (string.IsNullOrWhiteSpace(inputExpression)) throw new ArgumentNullException("The input expression cannot be empty.", nameof(inputExpression));

            double result = 0;
            var temp = new Stack<double>();

            for (int i = 0; i < inputExpression.Length; i++)
            {
                if (char.IsDigit(inputExpression[i]))
                {
                    string a = string.Empty;

                    while (!IsDelimeter(inputExpression[i]) && !IsOperator(inputExpression[i]))
                    {
                        a += inputExpression[i];
                        i++;
                        if (i == inputExpression.Length) break;
                    }

                    temp.Push(double.Parse(a, CultureInfo.InvariantCulture));
                    i--;
                }
                else if (IsOperator(inputExpression[i]))
                {
                    if (inputExpression[i] == '!') firstNumber = new Number { Value = temp.Pop() };
                    else
                    {
                        firstNumber = new Number { Value = temp.Pop() };
                        secondNumber = new Number { Value = temp.Pop() };
                    }

                    switch (inputExpression[i])
                    {
                        case '+': result = BinaryOperations.Addition(secondNumber, firstNumber).Value; break;
                        case '-': result = BinaryOperations.Subsctraction(secondNumber, firstNumber).Value; break;
                        case '*': result = BinaryOperations.Multiplication(secondNumber, firstNumber).Value; break;
                        case '/': result = BinaryOperations.Division(secondNumber, firstNumber).Value; break;
                        case '%': result = BinaryOperations.DivisionReaminder(secondNumber, firstNumber).Value; break;
                        case '^': result = UnaryOperations.Exponentiation(secondNumber, firstNumber).Value; break;
                        case '!': result = UnaryOperations.Factorial(firstNumber).Value; break;
                    }

                    temp.Push(result);
                }
            }

            return new Number { Value = temp.Peek() };
        }

        /// <summary>
        /// Checking the operation priority.
        /// </summary>
        /// <param name="operation"> Operation. </param>
        /// <returns> The priority of the operation. </returns>
        private static byte CheckedPriority(char operation)
        {
            if (char.IsDigit(operation)) throw new ArgumentException("The operation cannot be a number.", nameof(operation));

            switch (operation)
            {
                case '(': return 0;
                case ')': return 1;
                case '+': return 2;
                case '-': return 3;
                case '*': return 4;
                case '/': return 4;
                case '%': return 4;
                case '^': return 5;
                case '!': return 5;
                default: return 6;
            }
        }

        private static bool IsDelimeter(char c) => " =".IndexOf(c) != -1 ? true : false;

        private static bool IsOperator(char c) => "+-/%*^!()".IndexOf(c) != -1 ? true : false;
    }
}

using System;
using System.Globalization;
using System.Collections.Generic;
using TechnicalCalculator.BL.Model;
using TechnicalCalculator.BL.Model.Operations;

namespace TechnicalCalculator.BL.ViewModel
{
    public class ReversePolishNotation
    {
        public static string GetExpression(string inputExpression)
        {
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

        public static Number Counting(string inputExpression, Number firstNumber,Number secondNumber)
        {
            double result = 0;
            Stack<double> temp = new Stack<double>();

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
                    temp.Push(double.Parse(a,CultureInfo.InvariantCulture));
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

        private static byte CheckedPriority(char operation)
        {
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

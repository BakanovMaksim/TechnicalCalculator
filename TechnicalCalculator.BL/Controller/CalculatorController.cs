using System;
using TechnicalCalculator.BL.Model;

namespace TechnicalCalculator.BL.Controller
{
    public class CalculatorController
    {
        public Operands Operands { get; private set; }

        public Operations Operations { get; }

        public ResultNumber ResultNumber { get; private set; }

        public CalculatorController()
        {
            Operations = new Operations();
        }

        public void SelectedOperation(string operation, Operands operands)
        {
            Operands = operands;

            switch (operation)
            {
                case "+":
                    ResultNumber = Operations.Addition(operands.FirstNumber, operands.SecondNumber);
                    break;
                case "-":
                    ResultNumber = Operations.Subsctraction(operands.FirstNumber, operands.SecondNumber);
                    break;
                case "*":
                    ResultNumber = Operations.Multiplication(operands.FirstNumber, operands.SecondNumber);
                    break;
                case "/":
                    ResultNumber = Operations.Division(operands.FirstNumber, operands.SecondNumber);
                    break;
            }
        }
    }
}

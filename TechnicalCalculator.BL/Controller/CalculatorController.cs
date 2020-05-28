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

        public void SelectedOperation(string operation,Operands operands)
        {
            Operands = operands;

            switch(operation)
            {
                case "+":
                    Operations.Addition(operands.FirstNumber.Value,operands.SecondNumber.Value);
                    break;
                case "-":
                    Operations.Subsctraction(operands.FirstNumber.Value, operands.SecondNumber.Value);
                    break;
                case "*":
                    Operations.Multiplication(operands.FirstNumber.Value, operands.SecondNumber.Value);
                    break;
                case "/":
                    Operations.Division(operands.FirstNumber.Value, operands.SecondNumber.Value);
                    break;
            }

            //TODO: Дописать присвоение Result
        }
    }
}

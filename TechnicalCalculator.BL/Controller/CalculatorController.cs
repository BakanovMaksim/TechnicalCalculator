using System;
using TechnicalCalculator.BL.Model;

namespace TechnicalCalculator.BL.Controller
{
    public class CalculatorController
    {
        public Operands Operands { get; set; }

        public Operations Operations { get; }

        public CalculatorController()
        {
            Operations = new Operations();
        }

        public int SelectedOperation(string operation,int x,int y)
        {
            var result = 0;

            switch(operation)
            {
                case "+":
                    result = Operations.Addition(x,y);
                    break;
                case "-":
                    result = Operations.Subsctraction(x,y);
                    break;
                case "*":
                    result = Operations.Multiplication(x,y);
                    break;
                case "/":
                    result = Operations.Division(x,y);
                    break;
            }

            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcFunctions
{
    public class Calculator
    {

        public static IFunction Add(double num1, double num2)
        {
            return new Addition(num1, num2);
        }

        public static IFunction Subtract(double num1, double num2)
        {
            return new Subtraction(num1, num2);
        }

        public static IFunction Multiply(double num1, double num2)
        {
            return new Multiply(num1, num2);
        }

        public static IFunction Divide(double num1, double num2)
        {
            return new Division(num1, num2);
        }
    }
}

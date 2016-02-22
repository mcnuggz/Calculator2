using System;
using System.Threading;

namespace CalcFunctions
{
    internal class Division : IFunction
    {
        public double Number1 { get; private set; }
        public double Number2 { get; private set; }
        public double Result { get; private set; }

        public Division(double value1, double value2)
        {
            this.Number1 = value1;
            this.Number2 = value2;
        }
        public string Notify()
        {
            return String.Format("Numbers have been divided!"); ;
        }
        public double Calculate()
        {
            Console.WriteLine(Notify());
            Thread.Sleep(2000);
            if (Number1 != 0 || Number2 != 0)
            {
                return Result = Number1 / Number2;
            }
            else
            {
                throw new DivideByZeroException("Cannot divide by zero");
            }
            
        }
    }
}
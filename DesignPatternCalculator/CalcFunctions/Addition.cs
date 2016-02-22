using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CalcFunctions
{
    public class Addition : IFunction
    {
        public double Number1 { get; private set; }
        public double Number2 { get; private set; }        
        public double Result { get; private set; }

        public Addition(double value1, double value2)
        {
            this.Number1 = value1;
            this.Number2 = value2;
        }
        public string Notify()
        {
            return String.Format("Numbers have been added!"); ;
        }
        public double Calculate()
        {
            Console.WriteLine(Notify()); 
            Thread.Sleep(2000);
            return Result = Number1 + Number2;
        }
    }
}

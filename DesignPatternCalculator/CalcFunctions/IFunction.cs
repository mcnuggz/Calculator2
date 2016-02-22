using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcFunctions
{
    public interface IFunction
    {
        double Result { get; }
        double Number1 { get; }
        double Number2 { get; }
        double Calculate();
        string Notify();
    }
}

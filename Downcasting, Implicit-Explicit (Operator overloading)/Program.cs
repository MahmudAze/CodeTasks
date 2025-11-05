using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Downcasting__Implicit_Explicit__Operator_overloading_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region K -> C usage
            Celsius c = new Celsius(30);
            Kelvin k = c;
            Console.WriteLine(k.Degree);
            #endregion
        }
    }
}

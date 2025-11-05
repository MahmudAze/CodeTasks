using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Downcasting__Implicit_Explicit__Operator_overloading_
{
    public class Celsius
    {
        public double Degree { get; set; }

        public Celsius(double degree)
        {
            Degree = degree;
        }

        // Implicit operator: Celsius → Kelvin
        public static implicit operator Kelvin(Celsius celsius)
        {
            // 0°C = 273K
            return new Kelvin(celsius.Degree + 273);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics__Operator_overloading
{

    public class SimpleGenericType<T>
    {
        public T RandomValue { get; set; }
        public SimpleGenericType(T randommValue)
        {
            RandomValue = randommValue;
        }

        public void Print(T value)
        {
            Console.WriteLine();
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics__Operator_overloading
{
    class Pair<T1, T2>
    {
        public T1 First { get; set; }
        public T2 Second { get; set; }

        public Pair(T1 first, T2 second)
        {
            First = first;
            Second = second;
        }

        public void Display()
        {
            Console.WriteLine($"First: {First}, Second: {Second}");
        }
    }

}

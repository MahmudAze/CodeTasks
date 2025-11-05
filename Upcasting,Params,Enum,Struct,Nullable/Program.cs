using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Upcasting_Params_Enum_Struct_Nullable.Models;

namespace Upcasting_Params_Enum_Struct_Nullable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Eagle eagle = new Eagle();

            eagle.Eat(); 
            // Output: Eagle eating!

            Shark shark = new Shark();

            shark.Eat();
            // Output: Shark eating!
        }
    }
}

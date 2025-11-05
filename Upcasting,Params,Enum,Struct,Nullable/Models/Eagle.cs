using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upcasting_Params_Enum_Struct_Nullable
{
    public class Eagle : Bird
    {

        public override void Eat()
        {
            Console.WriteLine("Eagle eating!");
        }
    }
}

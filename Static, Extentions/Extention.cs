using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static__Extentions
{
    public static class Extention
    {
        public static int Power(int number, int power)
        {
            int result = 1;

            for (int i = 1; i <= power; i++)
            {
                result *= number;
            }

            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ1
{
    internal static class intExtention
    {
        public static int Reverse(this int num)
        {

            int reversed = 0, last;

            while (num > 0)
            {
                last = num % 10;
                reversed = reversed * 10 + last ;
                num /= 10;
            }

            return reversed;
        }
    }
}

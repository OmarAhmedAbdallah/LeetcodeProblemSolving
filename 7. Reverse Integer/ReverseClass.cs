using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems._7._Reverse_Integer
{
    internal static class ReverseClass
    {
        public static int Reverse(int x)
        {
            var res = 0;
            while (x != 0)
            {
                var result = x % 10;

                var lastRes = res;

                res = res * 10 + result;
                if (lastRes != ((res - result)/10)) return 0;

                x /= 10;
            }


            return res;
        }
    }
}

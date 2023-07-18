using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems._1071._Greatest_Common_Divisor_of_Strings
{
    internal static class GreatestCommonDivisorOfStringsClass
    {
        public static int gcd(int n1, int n2)
        {
            if (n2 == 0)
            {
                return n1;
            }
            else
            {
                return gcd(n2, n1 % n2);
            }
        }
        public static string GcdOfStrings(string str1, string str2)
        {
            int len1 = str1.Length;
            int len2 = str2.Length;
            if ((str1 + str2).Equals(str2 + str1))
            {
                int index = gcd(len1, len2);
                return str1.Substring(0, index);
            }
            else
            {
                return "";
            }
        }
    }
}

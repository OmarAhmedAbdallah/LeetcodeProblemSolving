using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems._2810._Faulty_Keyboard
{
    internal static class FinalStringClass
    {
        public static string FinalString(string s)
        {
            var result = new StringBuilder();
            for (int i = 0; i < s.Count(); i++)
            {
                if (s[i] == 'i')
                {
                   result = ReverseString(result);
                }
                else
                {
                    result.Append(s[i].ToString());
                }
            }

            return result.ToString();
        }

        static StringBuilder ReverseString(StringBuilder input)
        {
            var reversedSb = new StringBuilder();

            for (int j = input.Length - 1; j >= 0; j--)
            {
                reversedSb.Append(input[j]);
            }
            return reversedSb;
        }
    }
}

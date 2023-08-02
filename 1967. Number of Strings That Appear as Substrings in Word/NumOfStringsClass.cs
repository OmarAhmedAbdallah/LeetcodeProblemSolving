using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems._1967._Number_of_Strings_That_Appear_as_Substrings_in_Word
{
    internal static class NumOfStringsClass
    {
        public static int NumOfStrings(string[] patterns, string word)
        {
            int result = 0;

            foreach (var subWord in patterns)
            {
                if (word.Contains(subWord))
                {
                    result++;
                }
            }

            return result;
        }
    }
}

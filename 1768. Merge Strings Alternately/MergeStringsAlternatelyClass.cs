using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems._1768._Merge_Strings_Alternately
{
    internal static class MergeStringsAlternatelyClass
    {
        public static string MergeAlternately(string word1, string word2)
        {
            var result = "";

            var countWord1 = 0;
            var countWord2 = 0;

            for (int i = 0; i < (word1.Length + word2.Length); i++)
            {
                if ((i % 2 == 0 || countWord2 >= word2.Length) && countWord1 < word1.Length)
                {
                    result += word1[countWord1];
                    countWord1++;
                }
                else if((i % 2 == 1 || countWord1 >= word1.Length) && countWord2 < word2.Length)
                { 
                    result += word2[countWord2];
                    countWord2++;
                }
            }
            return result;
        }
    }
}

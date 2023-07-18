using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems._345._Reverse_Vowels_of_a_String
{
    internal static class ReverseVowelsClass
    {
        public static string ReverseVowels(string s)
        {
            var vowels = "aeiouAEIOU";
            var vowelsInS = s.Where(c => vowels.Contains(c)).ToList();

            var charsArr = s.ToCharArray();
            
            var count = vowelsInS.Count - 1;

            for (int i = 0; i < charsArr.Length; i++)
            {
                if (vowelsInS.Contains(charsArr[i]))
                {
                    charsArr[i] = vowelsInS[count];
                    count--;
                }
            }

            return new string(charsArr);
        }
    }
}

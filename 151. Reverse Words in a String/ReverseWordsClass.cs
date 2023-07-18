using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems._151._Reverse_Words_in_a_String
{
    internal static class ReverseWordsClass
    {
        public static string ReverseWords(string s)
        {
            s = s.Trim();
            var newStr = string.Empty;
            var isLastCharSpace = false;
            var word = string.Empty;

            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] == ' ' && !isLastCharSpace)
                {
                    newStr += new string(word.Reverse().ToArray()) + s[i];
                    word = string.Empty;
                    isLastCharSpace = true;
                }
                else if (s[i] != ' ')
                {
                    word += s[i];
                    isLastCharSpace = false;
                }
            }

            return newStr + new string(word.Reverse().ToArray());
        }
    }
}

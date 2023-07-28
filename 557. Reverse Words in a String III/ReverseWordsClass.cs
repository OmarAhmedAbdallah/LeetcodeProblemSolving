using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems._557._Reverse_Words_in_a_String_III
{
    internal class ReverseWordsClass
    {
        public string ReverseWords(string s)
        {
            string[] words = s.Split(" ");

            for (int i = 0; i < words.Length; i++)
            {
                char[] chars = words[i].ToCharArray();
                int l = 0, h = chars.Length - 1;
                while (l < h)
                {
                    (chars[l], chars[h]) = (chars[h], chars[l]);
                    l++;
                    h--;
                }
                words[i] = new string(chars);
            }
            return String.Join(" ", words);
        }
    }
}

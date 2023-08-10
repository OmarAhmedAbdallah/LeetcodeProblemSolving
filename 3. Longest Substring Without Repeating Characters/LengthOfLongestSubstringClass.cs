using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems._3._Longest_Substring_Without_Repeating_Characters
{
    public static class LengthOfLongestSubstringClass
    {
        public static int LengthOfLongestSubstring(string s)
        {
            List<char> letters = new List<char>();
            int maxLength = 0;

            foreach (char c in s)
            {
                if (!letters.Contains(c))
                {
                    letters.Add(c);
                }
                else
                {
                    maxLength = Math.Max(maxLength, letters.Count);

                    // remove preceding characters up to the duplicate letter
                    int idx = letters.IndexOf(c);
                    letters.RemoveRange(0, idx + 1);

                    letters.Add(c);
                }

            }
            



            return Math.Max(maxLength, letters.Count);
        }
    }
}

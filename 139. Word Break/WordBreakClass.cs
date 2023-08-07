using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems._139._Word_Break
{
    internal static class WordBreakClass
    {
        public static bool WordBreak(string s, IList<string> wordDict)
        {
            for (int i = 0; i < wordDict.Count; i++)
            {
                var index = s.IndexOf(wordDict[i], 0);

                if(index != -1)
                {
                    string str = new string('*', wordDict[i].Length);
                    s = s.Replace(wordDict[i], str);
                }
            }

            var resultStr = new string(s.Where(c => c != '*').ToArray());

            return resultStr.Length == 0;
        }
    }
}

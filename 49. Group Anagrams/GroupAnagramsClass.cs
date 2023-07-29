using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems._49._Group_Anagrams
{
    internal static class GroupAnagramsClass
    {
        public static IList<IList<string>> GroupAnagrams(string[] strs)
        {
            Dictionary<string, IList<string>> result = new();

            foreach (string word in strs)
            {
                var sortedWord = word.ToCharArray();

                Array.Sort(sortedWord);


                var sortedStr = new string(sortedWord);

                if (result.ContainsKey(sortedStr)) { result[sortedStr].Add(word); }
                else { result[sortedStr]= new List<string>() { word }; }
            }


            return result.Values.ToList();



        }
    }
}

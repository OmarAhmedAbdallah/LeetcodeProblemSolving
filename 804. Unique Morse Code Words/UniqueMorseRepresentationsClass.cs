using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems._804._Unique_Morse_Code_Words
{
    internal class UniqueMorseRepresentationsClass
    {
        public int UniqueMorseRepresentations(string[] words)
        {
            var iSCII = 97;
            var uniqueList = new List<string>();
            var code = new List<string>() {
                ".-","-...","-.-.","-..",".","..-.","--.","....","..",".---","-.-",".-..","--","-.","---",".--.","--.-",".-.","...","-","..-","...-",".--","-..-","-.--","--.."
            };

            for (int i = 0; i < words.Length; i++)
            {
                var word = "";
                for (int j = 0; j < words[i].Length; j++)
                {
                    word += code[(int)words[i][j] - iSCII];
                }

                if(!uniqueList.Contains(word))
                {
                    uniqueList.Add(word);
                }
            }


            return uniqueList.Count;
        }
    }
}

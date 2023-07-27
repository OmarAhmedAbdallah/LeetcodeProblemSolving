using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems._2325._Decode_the_Message
{
    internal static class DecodeMessageClass
    {
        public static string DecodeMessage(string key, string message)
        {
            var result = "";

            var decodedChars = new Dictionary<char, char>();

            var aSCII = 97;

            foreach (char c in key)
            {
                if (!decodedChars.ContainsKey(c) && c != ' ')
                {
                    decodedChars[c] = (char)aSCII;
                    aSCII++;
                }
            }

            foreach (var c in message)
            {
                result += c == ' ' ? ' ' : decodedChars[c];
            }

            return result;
        }
    }
}

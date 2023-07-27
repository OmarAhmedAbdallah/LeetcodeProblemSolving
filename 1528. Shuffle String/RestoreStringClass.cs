using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems._1528._Shuffle_String
{
    internal class RestoreStringClass
    {
        public string RestoreString(string s, int[] indices)
        {
            char[] charArr = new char[s.Length];

            for (int i = 0; i < charArr.Length; i++)
            {
                charArr[indices[i]] = s[i];
            }

            return new string(charArr);
        }
    }
}

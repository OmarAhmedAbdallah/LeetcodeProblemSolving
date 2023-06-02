using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems._383._Ransom_Note
{
    internal class CanConstructClass
    {
        public bool CanConstruct(string ransomNote, string magazine)
        {
            List<char> charsList = new List<char>(magazine);
            for (int i = 0; i < ransomNote.Length; i++)
            {
                if (charsList.Contains(ransomNote[i]))
                {
                    charsList.Remove(ransomNote[i]);
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}

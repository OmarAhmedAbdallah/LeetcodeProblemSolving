using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems._1773._Count_Items_Matching_a_Rule
{
    internal class CountMatchesClass
    {
        public int CountMatches(IList<IList<string>> items, string ruleKey, string ruleValue)
        {
            int i;
            if (ruleKey == "type") i = 0;
            else if (ruleKey == "color") i = 1;
            else if (ruleKey == "name") i = 2;
            else return -1;

            int ans = 0;

            for (int j = 0; j < items.Count; j++)
            {
                if (items[j][i] == ruleValue) ans++;
            }

            return ans;
        }
    }
}

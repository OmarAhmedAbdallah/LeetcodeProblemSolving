using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems._347._Top_K_Frequent_Elements
{
    internal static class TopKFrequentClass
    {
        public static int[] TopKFrequent(int[] nums, int k)
        {
            Dictionary<int,int> result = new Dictionary<int,int>();

            foreach (int i in nums)
            {
                if(result.ContainsKey(i))
                {
                    result[i]++;
                }
                else
                {
                    result[i] = 1;
                }
            }

            var resArr = result.OrderByDescending(x => x.Value).Take(k).Select(x=> x.Key).ToArray();

            return resArr;
        }
        
    }
}

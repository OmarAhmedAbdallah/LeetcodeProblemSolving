using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems._1512._Number_of_Good_Pairs
{
    internal class NumIdenticalPairsClass
    {
        public int NumIdenticalPairs(int[] nums)
        {
            var res = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        res++;
                    }
                }
            }

            return res;
        }
    }
}

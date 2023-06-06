using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.FindMaxConsecutiveOnes
{
    internal class MaxConsecutiveOnesClass
    {
        public int FindMaxConsecutiveOnes(int[] nums)
        {
            int max = 0,lastMax = 0;
            foreach (var num in nums)
            {
                if(num == 1)
                {
                    max++;
                }
                else
                {
                    if (max > lastMax)
                    {
                        lastMax = max;
                    }
                    max = 0;
                }
            }

            return max > lastMax? max : lastMax;
        }
    }
}

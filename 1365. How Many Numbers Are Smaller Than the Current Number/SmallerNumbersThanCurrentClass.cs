using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems._1365._How_Many_Numbers_Are_Smaller_Than_the_Current_Number
{
    public static class SmallerNumbersThanCurrentClass
    {
        //From discussion
        public static int[] SmallerNumbersThanCurrent(int[] nums)
        {
            int[] count = new int[101];
            int[] res = new int[nums.Count()];

            for (int i = 0; i < nums.Count(); i++)
            {
                count[nums[i]]++;
            }

            for (int i = 1; i <= 100; i++)
            {
                count[i] += count[i - 1];
            }

            for (int i = 0; i < nums.Count(); i++)
            {
                if (nums[i] == 0)
                    res[i] = 0;
                else
                    res[i] = count[nums[i] - 1];
            }

            return res;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems._80._Remove_Duplicates_from_Sorted_Array_II
{
    internal static class RemoveDuplicatesClass
    {
        public static int RemoveDuplicates(int[] nums)
        {
            int count = 0;
            bool isPrevTwice = false;
            for (int i = 1; i < nums.Length; i++)
            {
                bool isCurrentTwice = nums[count] == nums[i];
                if (!isCurrentTwice || !isPrevTwice)
                    nums[++count] = nums[i];
                isPrevTwice = isCurrentTwice;
            }
            return count + 1;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems._189._Rotate_Array
{
    internal static class RotateClass
    {
        public static void Rotate(int[] nums, int k)
        {
            var newK = k % nums.Length;
            var count = newK - 1;

            int[] output = new int[nums.Length];

            for (int i = nums.Length - 1; i > nums.Length - 1 - newK; i--)
            {
                output[count--] = nums[i];
            }

            for (int i = 0; i < nums.Length - newK; i++)
            {
                output[i + newK] = nums[i]; 
            }

            nums = output;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems._238._Product_of_Array_Except_Self
{
    internal static class ProductExceptSelfClass
    {
        public static int[] ProductExceptSelf(int[] nums)
        {
            var arrLength = nums.Length;
            var output = new int[arrLength];

            for (int i = 0, prev = 1; i < arrLength; i++)
            {
                output[i] = prev;
                prev = nums[i] * prev;
            }

            for (int i = arrLength - 1, prev = 1; i >= 0; i--)
            {
                output[i] = output[i] * prev;
                prev = nums[i] * prev;
            }
            return output;
        }
    }
}

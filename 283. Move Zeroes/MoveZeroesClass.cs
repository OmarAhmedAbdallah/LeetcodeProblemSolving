using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems._283._Move_Zeroes
{
    internal static class MoveZeroesClass
    {
        public static void MoveZeroes(int[] nums)
        {
            if (nums == null || nums.Length == 0) return;

            var p1 = 0; var p2 = 1;

            while (p2 < nums.Length)
            {
                if (nums[p1] == 0 && nums[p2] != 0)
                {
                    SwapWithTemp(ref nums[p1], ref nums[p2]);
                    p1++;
                    p2++;
                }
                else
                {
                    if(nums[p1] != 0)
                    {
                        p1++;
                    }
                    p2++;
                }
            }


            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }
        }

        public static void SwapWithTemp(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}

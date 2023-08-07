using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems._2610._Convert_an_Array_Into_a_2D_Array_With_Conditions
{
    internal static class FindMatrixClass
    {
        public static IList<IList<int>> FindMatrix(int[] nums)
        {
            Array.Sort(nums);
            IList<IList<int>> ints = new List<IList<int>>();

            if(nums.Length == 0) { return ints; }
            var lastInt = nums[0];
            var lastLeaf = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == lastInt)
                {
                    if (lastLeaf < ints.Count -1 && ints[lastLeaf].Contains(nums[i]))
                    {
                        lastLeaf++;
                        lastInt = nums[i];
                        i--;
                    }
                    else
                    {
                        if(lastLeaf <= ints.Count - 1)
                        {
                            ints[lastLeaf].Add(nums[i]);
                        }
                        else
                        {
                            IList<int> l = new List<int>();
                            l.Add(nums[i]);
                            ints.Add(l);
                        }
                        
                        lastLeaf++;
                        lastInt = nums[i];
                    }
                }
                else
                {
                    lastLeaf = 0;
                    ints[lastLeaf].Add(nums[i]);
                    lastInt = nums[i];
                }


            }

            return ints;

        }
    }
}

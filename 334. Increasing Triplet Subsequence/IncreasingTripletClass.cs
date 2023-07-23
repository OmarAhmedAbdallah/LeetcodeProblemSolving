using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems._334._Increasing_Triplet_Subsequence
{
    internal class IncreasingTripletClass
    {
        public bool IncreasingTriplet(int[] nums)
        {
            if (nums.Length < 3)
            {
                return false;
            }

            int smallest = int.MaxValue;
            int secondSmallest = int.MaxValue;

            foreach (int num in nums)
            {
                if (num <= smallest)
                {
                    smallest = num;
                }
                else if (num <= secondSmallest)
                {
                    secondSmallest = num;
                }
                else
                {
                    return true;
                }
            }

            return false;
        }
    }
}

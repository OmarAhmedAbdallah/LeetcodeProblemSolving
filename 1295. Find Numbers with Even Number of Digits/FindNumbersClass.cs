using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.FindNumbers
{
    internal class FindNumbersClass
    {
        public int FindNumbers(int[] nums)
        {
            var numOfEven = 0;
            foreach (int num in nums)
            {
                int digitCount = (int)Math.Floor(Math.Log10(num) + 1);
                if (digitCount % 2 == 0)
                {
                    numOfEven++;
                }
            }
            return numOfEven;
        }
    }
}

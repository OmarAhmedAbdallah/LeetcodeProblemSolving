using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems._1342._Number_of_Steps_to_Reduce_a_Number_to_Zero
{
    internal class NumberOfStepsClass
    {
        public int NumberOfSteps(int num)
        {
            if (num == 0) return 0;

            else if (num % 2 == 0)
            {
                var resEven = NumberOfSteps(num / 2);
                return 1 + resEven;
            }

            var resOdd = NumberOfSteps(num - 1);
            return 1 + resOdd;
        }
    }
}

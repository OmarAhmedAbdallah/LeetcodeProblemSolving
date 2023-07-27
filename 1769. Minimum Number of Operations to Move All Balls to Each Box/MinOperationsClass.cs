using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems._1769._Minimum_Number_of_Operations_to_Move_All_Balls_to_Each_Box
{
    public static class MinOperationsClass
    {
        public static int[] MinOperations(string boxes)
        {
            int[] result = new int[boxes.Length];
            var indexes = Enumerable.Range(0, boxes.Length)
                                          .Where(i => boxes[i] == '1')
                                          .ToArray();

            var indexesSum = indexes.Length;

            for (int i = 0; i < boxes.Length; i++)
            {
                foreach (var index in indexes)
                {
                    result[i] += Math.Abs(index - i);
                }
            }

            return result;
        }
    }
}

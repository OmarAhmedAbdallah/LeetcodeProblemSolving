using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems._2011._Final_Value_of_Variable_After_Performing_Operations
{
    internal static class FinalValueAfterOperationsClass
    {
        public static int FinalValueAfterOperations(string[] operations)
        {
            var maxNum = 0;
            var result = operations.GroupBy(x => x)
                 .Select(x => new { Key = x.Key, Count = x.Count() })
                 .ToArray();

            foreach (var item in result)
            {
                maxNum += item.Key.Contains("++") ? item.Count : - item.Count;
            }

            return maxNum;
        }



    }
}

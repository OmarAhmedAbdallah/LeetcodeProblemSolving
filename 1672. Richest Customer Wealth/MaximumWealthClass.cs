using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems._1672._Richest_Customer_Wealth
{
    internal class MaximumWealthClass
    {
        public int MaximumWealth(int[][] accounts)
        {
            int max = 0;
            foreach (var cust in accounts)
                max = Math.Max(max, cust.Sum());
            return max;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems._1689._Partitioning_Into_Minimum_Number_Of_Deci_Binary_Numbers
{
    internal class MinPartitionsClass
    {
        public int MinPartitions(string n)
        {
            return n.Max() - '0';
        }
    }
}

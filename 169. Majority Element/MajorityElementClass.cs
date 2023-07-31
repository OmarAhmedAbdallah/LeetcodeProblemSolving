using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems._169._Majority_Element
{
    internal class MajorityElementClass
    {
        public int MajorityElement(int[] nums)
        {
            Dictionary<int, int> dic = new();
            var majorityNum = 0;
            var maxAppears = 0;
            foreach (int num in nums)
            {
                if (dic.ContainsKey(num))
                {
                    dic[num]++;
                    if (maxAppears < dic[num])
                    {
                        majorityNum = num;
                        maxAppears = dic[num];
                    }
                }
                else
                {
                    dic[num] = 1;

                    if(maxAppears == 0)
                    {
                        majorityNum = num;
                        maxAppears = 1;
                    }
                }
            }


            return majorityNum;
        }
    }
}

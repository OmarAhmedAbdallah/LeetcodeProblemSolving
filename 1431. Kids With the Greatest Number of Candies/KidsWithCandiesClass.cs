using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems._1431._Kids_With_the_Greatest_Number_of_Candies
{
    internal static class KidsWithCandiesClass
    {
        public static IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            var greatestNumberOfCandies = candies.Max();
            IList<bool> result = new List<bool>();

            foreach (var candy in candies)
            {
                var isGreatest = candy + extraCandies >= greatestNumberOfCandies;
                result.Add(isGreatest);
            }

            return result;
        }
    }
}

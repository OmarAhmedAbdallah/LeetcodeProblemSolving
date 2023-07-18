using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace LeetCodeProblems._605._Can_Place_Flowers
{
    internal static class CanPlaceFlowersClass
    {
        public static bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            var sequenceAdjacentPlots = 0;
            var maxSequenceAdjacentPlots = 0;

            for (int i = 0; i < flowerbed.Length; i++)
            {
                var currentPot = flowerbed[i];
                var lastPot = i == 0 ? 0 : flowerbed[i - 1];
                var nextPot = i == flowerbed.Length - 1 ? 0 : flowerbed[i + 1];

                if (currentPot == 0 && lastPot == 0 && nextPot == 0)
                {
                    flowerbed[i] = 1;
                    sequenceAdjacentPlots++;
                }
            }
            return sequenceAdjacentPlots >= n;
        }
    }
}

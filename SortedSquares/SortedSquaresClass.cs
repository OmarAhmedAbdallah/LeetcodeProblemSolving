using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.SortedSquares
{
    internal class SortedSquaresClass
    {
        public int[] SortedSquares(int[] nums)
        {
            var sortedNums = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                var sqrNum = (int)Math.Pow(nums[i],2);
                sortedNums[i] = sqrNum;
            }
            Array.Sort(sortedNums);
            return sortedNums;
        }
        public static void QuickSort(int[] array, int low, int high)
        {
            if (low < high)
            {
                int pivotIndex = Partition(array, low, high);

                QuickSort(array, low, pivotIndex - 1);
                QuickSort(array, pivotIndex + 1, high);
            }
        }

        private static int Partition(int[] array, int low, int high)
        {
            int pivot = Math.Abs(array[high]);
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (Math.Abs(array[j]) < pivot)
                {
                    i++;
                    Swap(array, i, j);
                }
            }

            Swap(array, i + 1, high);

            return i + 1;
        }

        private static void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}

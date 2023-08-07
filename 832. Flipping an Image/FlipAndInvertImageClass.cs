using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems._832._Flipping_an_Image
{
    internal static class FlipAndInvertImageClass
    {
        public static int[][] FlipAndInvertImage(int[][] image)
        {
            for (int i = 0; i < image.Length; i++)
            {
                int j = 0;
                int k = image[i].Length - 1;
                while (k + 1 != j && k != j)
                {
                    image[i][j] = image[i][j] ^ image[i][k];
                    image[i][k] = image[i][j] ^ image[i][k];
                    image[i][j] = image[i][j] ^ image[i][k];

                    image[i][k] = image[i][k] ^ 1;
                    image[i][j] = image[i][j] ^ 1;
                    k--;
                    j++;
                }

                if(k == j )
                {
                    image[i][j] = image[i][j] ^ 1;
                }
            }

            return image;
        }
    }
}

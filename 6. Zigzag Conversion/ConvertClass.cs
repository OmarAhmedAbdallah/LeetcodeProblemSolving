
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems._6._Zigzag_Conversion
{
    internal static class ConvertClass
    {
        public static string Convert(string s, int numRows)
        {
            var arrInput = s.ToCharArray();
            bool goVertical = true;

            var result = new StringBuilder[numRows];

            var j = 0;
            var y = 0;


            for (int i = 0; i < arrInput.Length; i++)
            {
                if (result?[j] == null)
                {
                    result[j] = new StringBuilder();
                }
                result[j].Append(arrInput[i]);

                if(numRows > 1) // No ZigZag
                {
                    if (j == numRows - 1)
                    {
                        goVertical = false;
                    }
                    else if (j == 0)
                    {
                        goVertical = true;
                    }

                    if (goVertical)
                    {
                        j++;
                    }
                    else
                    {
                        j--;
                        y++;
                    }
                }
            }

            StringBuilder resultBuilder = result.Aggregate(new StringBuilder(), (acc, sb) => acc.Append(sb));



            return resultBuilder.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems._43._Multiply_Strings
{
    internal static class MultiplyClass
    {
        public static string Multiply(string num1, string num2)
        {
            if (num1 == "0" || num2 == "0") return "0";

            var result = new int[num1.Length + num2.Length];

            for (int i = num1.Length - 1; i >= 0; i--)
            {
                for (int j = num2.Length - 1; j >= 0; j--)
                {
                    result[i + j + 1] += (num1[i] - '0') * (num2[j] - '0');
                    result[i + j] += result[i + j + 1] / 10;
                    result[i + j + 1] %= 10;
                }
            }

            int k = 0;
            string ans = "";
            while (result[k] == 0) k++;
            while (k < result.Length) ans += result[k++].ToString();

            return ans;
        }
    }
}

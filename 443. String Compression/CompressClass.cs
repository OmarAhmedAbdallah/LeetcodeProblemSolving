using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems._443._String_Compression
{
    internal static class CompressClass
    {
        public static int Compress(char[] chars)
        {
            if (chars.Length < 0) return 0;
            if (chars.Length < 1) return 1;

            var consecutiveLen = 0;
            var prevChar = default(char);
            var resultPointer = 0;

            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == prevChar || prevChar == default(char))
                {
                    consecutiveLen++;

                    if (i == chars.Length - 1)
                    {
                        chars[resultPointer] = chars[i];

                        resultPointer++;

                        resultPointer = AddNum(chars, consecutiveLen, resultPointer);
                    }
                }
                else
                {
                    chars[resultPointer] = chars[i - 1];

                    resultPointer++;

                    resultPointer = AddNum(chars, consecutiveLen, resultPointer);

                    consecutiveLen = 1;

                    if (i == chars.Length - 1)
                    {
                        chars[resultPointer] = chars[i];

                        resultPointer++;

                        resultPointer = AddNum(chars, consecutiveLen, resultPointer);
                    }
                }

                prevChar = chars[i];
            }

            foreach (var item in chars)
            {
                Console.WriteLine(item);
            }
            return resultPointer;
        }


        private static int AddNum(char[] chars, int num, int pointer)
        {
            if (num > 1)
            {
                char[] charArray = num.ToString().ToCharArray();

                foreach (char c in charArray)
                {
                    chars[pointer] = c;
                    pointer++;
                }
            }

            return pointer;
        }

        public static int Compress1(char[] chars)
        {
            var i = 0;
            var j = 0;

            while (i < chars.Length)
            {
                var current = chars[i];
                var counter = 0;

                while (i < chars.Length && chars[i] == current)
                {
                    i++;
                    counter++;
                }

                chars[j++] = current;

                if (counter > 1)
                {
                    foreach (var counterChar in counter.ToString())
                    {
                        chars[j++] = counterChar;
                    }
                }
            }
            Console.WriteLine("==========================================");

            foreach (var item in chars)
            {
                Console.WriteLine(item);
            }
            return j;
        }
    }
}

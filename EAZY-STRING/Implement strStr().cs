using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode1.EAZY
{
    internal class Implement_strStr__
    {
        public class Solution
        {
            public int StrStr(string haystack, string needle)
            {
                int n = haystack.Length;
                int m = needle.Length;

                // Optimization: needle cannot fit if it's longer than haystack
                if (m > n) return -1;

                // Iterate through haystack
                // Note: we only need to go up to n - m
                for (int i = 0; i <= n - m; i++)
                {

                    // Check if the substring matches needle
                    bool match = true;
                    for (int j = 0; j < m; j++)
                    {
                        if (haystack[i + j] != needle[j])
                        {
                            match = false;
                            break;
                        }
                    }

                    if (match)
                    {
                        return i;
                    }
                }

                return -1;
            }
        }

    }
}

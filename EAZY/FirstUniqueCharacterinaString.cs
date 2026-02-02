using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode1.EAZY
{
    public class FirstUniqueCharacterinaString
    {
        public class Solution
        {
            public int FirstUniqChar(string s)
            {
                int[] count = new int[26];

                // Pass 1: Count frequencies
                foreach (char c in s)
                {
                    count[c - 'a']++;
                }

                // Pass 2: Check indices in order
                for (int i = 0; i < s.Length; i++)
                {
                    if (count[s[i] - 'a'] == 1)
                    {
                        return i;
                    }
                }

                return -1;
            }
        }
    }
}

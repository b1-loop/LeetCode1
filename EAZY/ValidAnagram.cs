using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode1.EAZY
{
    public class ValidAnagram
    {
        public class Solution
        {
            public bool IsAnagram(string s, string t)
            {
                // Quick check: Anagrams must be same length
                if (s.Length != t.Length)
                {
                    return false;
                }

                // Frequency table for 'a'-'z'
                int[] count = new int[26];

                // 1. Count frequencies in s
                for (int i = 0; i < s.Length; i++)
                {
                    count[s[i] - 'a']++;
                }

                // 2. Subtract frequencies using t
                for (int i = 0; i < t.Length; i++)
                {
                    // Optimization: If we decrement and it goes below 0,
                    // t has "more" of this char than s, so it's invalid.
                    count[t[i] - 'a']--;
                    if (count[t[i] - 'a'] < 0)
                    {
                        return false;
                    }
                }

                return true;
            }
        }
    }
}

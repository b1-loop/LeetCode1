using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode1.EAZY
{
    public class ValidPalindrome
    {
        public class Solution
        {
            public bool IsPalindrome(string s)
            {
                int left = 0;
                int right = s.Length - 1;

                while (left < right)
                {
                    // 1. Move left pointer forward until we find a valid char
                    if (!char.IsLetterOrDigit(s[left]))
                    {
                        left++;
                    }
                    // 2. Move right pointer backward until we find a valid char
                    else if (!char.IsLetterOrDigit(s[right]))
                    {
                        right--;
                    }
                    // 3. Both are valid; compare them
                    else
                    {
                        if (char.ToLower(s[left]) != char.ToLower(s[right]))
                        {
                            return false;
                        }
                        // Match found, move both pointers inward
                        left++;
                        right--;
                    }
                }

                return true;
            }
        }
    }
}

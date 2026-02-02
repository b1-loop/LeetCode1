using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode1.EAZY
{
    public class ReverceString
    {
        public class Solution
        {
            public void ReverseString(char[] s)
            {
                int left = 0;
                int right = s.Length - 1;

                while (left < right)
                {
                    // Swap characters using a temporary variable
                    char temp = s[left];
                    s[left] = s[right];
                    s[right] = temp;

                    // Move pointers inward
                    left++;
                    right--;
                }
            }
        }
    }
}

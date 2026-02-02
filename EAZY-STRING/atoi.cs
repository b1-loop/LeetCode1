using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode1.EAZY
{
    public class atoi
    {
        public class Solution
        {
            public int MyAtoi(string s)
            {
                int index = 0;
                int n = s.Length;

                // 1. Whitespace: Skip leading spaces
                while (index < n && s[index] == ' ')
                {
                    index++;
                }

                // Edge case: String was empty or contained only spaces
                if (index == n) return 0;

                // 2. Signedness: Check for sign
                int sign = 1;
                if (s[index] == '-')
                {
                    sign = -1;
                    index++;
                }
                else if (s[index] == '+')
                {
                    index++;
                }

                // 3. Conversion & Rounding
                int result = 0;
                int threshold = int.MaxValue / 10; // 214748364

                while (index < n && char.IsDigit(s[index]))
                {
                    int digit = s[index] - '0';

                    // Check for Overflow/Underflow BEFORE updating result
                    // We check against positive limits. 
                    // If result > 214748364, adding any digit will overflow.
                    // If result == 214748364, adding 8 or 9 will overflow.
                    if (result > threshold || (result == threshold && digit > 7))
                    {
                        return sign == 1 ? int.MaxValue : int.MinValue;
                    }

                    result = result * 10 + digit;
                    index++;
                }

                return result * sign;
            }
        }
    }
}

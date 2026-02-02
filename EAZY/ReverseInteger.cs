using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode1.EAZY
{
    public class ReverseInteger
    {
        public class Solution
        {
            public int Reverse(int x)
            {
                int result = 0;

                while (x != 0)
                {
                    // 1. Get the last digit
                    // In C#, -123 % 10 results in -3, so signs are handled automatically
                    int pop = x % 10;
                    x /= 10;

                    // 2. Check for Positive Overflow
                    // int.MaxValue is 2147483647
                    // If result > 214748364, multiplying by 10 causes overflow.
                    // If result == 214748364, we must make sure the incoming digit isn't > 7.
                    if (result > int.MaxValue / 10 ||
                       (result == int.MaxValue / 10 && pop > 7))
                    {
                        return 0;
                    }

                    // 3. Check for Negative Underflow
                    // int.MinValue is -2147483648
                    // If result < -214748364, multiplying by 10 causes underflow.
                    // If result == -214748364, we must make sure the incoming digit isn't < -8.
                    if (result < int.MinValue / 10 ||
                       (result == int.MinValue / 10 && pop < -8))
                    {
                        return 0;
                    }

                    // 4. Push the digit
                    result = result * 10 + pop;
                }

                return result;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode1.EAZY_ARRAY
{
    public class SingleNumber
    {
        public class Solution
        {
            public int SingleNumber(int[] nums)
            {
                int result = 0;

                // Vi loopar igenom varje tal i arrayen
                foreach (int num in nums)
                {
                    // Vi använder XOR-operatorn (^) för att "slå ihop" talen
                    result ^= num;
                }

                return result;
            }
        }
    }
}

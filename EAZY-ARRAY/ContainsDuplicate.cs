using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode1.EAZY_ARRAY
{
    public class ContainsDuplicate
    {
        public class Solution
        {
            public bool ContainsDuplicate(int[] nums)
            {
                HashSet<int> seen = new HashSet<int>();

                foreach (int num in nums)
                {
                    // Add returns false if the element is already in the set
                    if (!seen.Add(num))
                    {
                        return true;
                    }
                }

                return false;
            }
        }
    }
}

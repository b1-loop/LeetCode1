using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode1.EAZY_ARRAY
{
    public class RemoveDuplicatesfromSortedArray
    {
        public class Solution
        {
            public int RemoveDuplicates(int[] nums)
            {
                // Edge case: if length is 0 or 1, it's already unique
                if (nums.Length == 0) return 0;

                int insertIndex = 1;

                // Start scanning from the second element
                for (int i = 1; i < nums.Length; i++)
                {
                    // If current element is different from the previous one, it's unique
                    if (nums[i] != nums[i - 1])
                    {
                        nums[insertIndex] = nums[i];
                        insertIndex++;
                    }
                }

                return insertIndex;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode1.EAZY_ARRAY
{
    public class RotateArray
    {
        public class Solution
        {
            public void Rotate(int[] nums, int k)
            {
                int n = nums.Length;
                // 1. Normalize k
                k = k % n;

                // 2. Reverse the whole array
                Reverse(nums, 0, n - 1);

                // 3. Reverse the first k elements
                Reverse(nums, 0, k - 1);

                // 4. Reverse the rest
                Reverse(nums, k, n - 1);
            }

            // Helper function to reverse a portion of the array
            private void Reverse(int[] nums, int start, int end)
            {
                while (start < end)
                {
                    int temp = nums[start];
                    nums[start] = nums[end];
                    nums[end] = temp;
                    start++;
                    end--;
                }
            }
        }
    }
}

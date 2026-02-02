using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode1.EAZY_ARRAY
{
    public class MoveZeroes
    {
        public class Solution
        {
            public void MoveZeroes(int[] nums)
            {
                int insertPos = 0;

                // Loopa igenom hela arrayen
                for (int i = 0; i < nums.Length; i++)
                {

                    // Om vi hittar en siffra som INTE är noll
                    if (nums[i] != 0)
                    {

                        // Byt plats på siffrorna (Swap)
                        // Vi lägger den icke-nollan på 'insertPos'
                        int temp = nums[insertPos];
                        nums[insertPos] = nums[i];
                        nums[i] = temp;

                        // Flytta fram markören för var nästa icke-nolla ska bo
                        insertPos++;
                    }
                }
            }
        }
    }
}

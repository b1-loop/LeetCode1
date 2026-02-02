using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode1.EAZY_ARRAY
{
    public class BestTimetoBuyandSellStockII
    {
        public class Solution
        {
            public int MaxProfit(int[] prices)
            {
                int maxProfit = 0;

                // Start from the second day (index 1)
                for (int i = 1; i < prices.Length; i++)
                {
                    // If today's price is higher than yesterday's
                    if (prices[i] > prices[i - 1])
                    {
                        // We capture the profit immediately
                        maxProfit += prices[i] - prices[i - 1];
                    }
                }

                return maxProfit;
            }
        }
    }
}

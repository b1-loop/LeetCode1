using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode1.EAZY_ARRAY
{
    public class TwoSum
    {
        public class Solution
        {
            public int[] TwoSum(int[] nums, int target)
            {
                // Skapa en dictionary för att lagra talet och dess index.
                // Key = Talet (värdet i nums)
                // Value = Indexet (positionen i nums)
                Dictionary<int, int> numMap = new Dictionary<int, int>();

                for (int i = 0; i < nums.Length; i++)
                {
                    int currentNum = nums[i];
                    int complement = target - currentNum;

                    // Steg 1: Kolla om det tal vi behöver (complement) redan finns i vår dictionary
                    if (numMap.ContainsKey(complement))
                    {
                        // Om det finns, har vi hittat paret!
                        // Returnera indexet för komplementet och nuvarande index.
                        return new int[] { numMap[complement], i };
                    }

                    // Steg 2: Om vi inte hittat komplementet än, lägg till nuvarande tal i dictionaryn
                    // Vi kollar först så nyckeln inte redan finns (även om problembeskrivningen säger unik lösning)
                    if (!numMap.ContainsKey(currentNum))
                    {
                        numMap.Add(currentNum, i);
                    }
                }

                // Returnera en tom array eller kasta undantag om ingen lösning finns (enligt kravbilden finns dock alltid en)
                return new int[0];
            }
        }
    }
}

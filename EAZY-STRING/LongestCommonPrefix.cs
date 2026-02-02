using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode1.EAZY
{
    public class LongestCommonPrefix
    {
        public class Solution
        {
            public string LongestCommonPrefix(string[] strs)
            {
                if (strs == null || strs.Length == 0)
                {
                    return "";
                }

                // Start assuming the whole first string is the prefix
                string prefix = strs[0];

                for (int i = 1; i < strs.Length; i++)
                {
                    // While the current string does not start with the prefix
                    // (IndexOf returns 0 when the prefix is found at the start)
                    while (strs[i].IndexOf(prefix) != 0)
                    {
                        // Shorten the prefix from the end
                        prefix = prefix.Substring(0, prefix.Length - 1);

                        // Optimization: If prefix becomes empty, stop
                        if (string.IsNullOrEmpty(prefix))
                        {
                            return "";
                        }
                    }
                }

                return prefix;
            }
        }
    }
}

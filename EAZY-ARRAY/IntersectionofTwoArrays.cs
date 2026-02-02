using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode1.EAZY_ARRAY
{
    public class IntersectionofTwoArrays
    {
        public class Solution
        {
            public int[] Intersect(int[] nums1, int[] nums2)
            {
                // 1. Skapa en Dictionary för att räkna frekvenser
                // Key (int) = Siffran
                // Value (int) = Antal gånger den finns
                Dictionary<int, int> counts = new Dictionary<int, int>();

                // Fyll Dictionary med siffror från nums1
                foreach (int num in nums1)
                {
                    if (counts.ContainsKey(num))
                    {
                        counts[num]++;
                    }
                    else
                    {
                        counts[num] = 1;
                    }
                }

                // 2. Skapa en lista för resultatet (eftersom vi inte vet hur stort det blir än)
                List<int> result = new List<int>();

                // 3. Gå igenom nums2 och hitta matchningar
                foreach (int num in nums2)
                {
                    // Kolla om siffran finns i vår counts och att vi har "saldo" kvar (> 0)
                    if (counts.ContainsKey(num) && counts[num] > 0)
                    {
                        result.Add(num);
                        counts[num]--; // Minska saldot så vi inte återanvänder samma "instans"
                    }
                }

                // 4. Konvertera listan tillbaka till en array (som uppgiften kräver)
                return result.ToArray();
            }
        }
    }
}

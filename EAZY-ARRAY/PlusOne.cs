using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode1.EAZY_ARRAY
{
    public class PlusOne
    {
        public class Solution
        {
            public int[] PlusOne(int[] digits)
            {
                // Vi börjar från sista indexet (längden - 1)
                // och går bakåt mot index 0.
                for (int i = digits.Length - 1; i >= 0; i--)
                {

                    // Fall 1: Om siffran är mindre än 9
                    if (digits[i] < 9)
                    {
                        digits[i]++; // Plussa på 1
                        return digits; // Vi är klara! Returnera direkt.
                    }

                    // Fall 2: Siffran är 9
                    // Den blir 0, och loopen fortsätter för att hantera minnessiffran
                    digits[i] = 0;
                }

                // Fall 3: Om vi kommer hit betyder det att loopen körde klart
                // utan att returnera. Det innebär att ALLA siffror var 9.
                // Exempel: [9, 9] har blivit [0, 0].
                // Vi behöver skapa en ny array som är 1 större.
                int[] result = new int[digits.Length + 1];

                // I C# är alla platser i en ny int-array automatiskt 0.
                // Så result är nu [0, 0, 0]. Vi sätter första siffran till 1.
                result[0] = 1;

                return result;
            }
        }
    }
}

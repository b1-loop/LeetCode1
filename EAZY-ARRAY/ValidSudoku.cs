using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode1.EAZY_ARRAY
{
    public class ValidSudoku
    {
        public class Solution
        {
            public bool IsValidSudoku(char[][] board)
            {
                // Vi skapar arrayer av HashSets för att hålla reda på sedda siffror.
                // Index 0 till 8 representerar rad/kolumn/box-nummer.
                HashSet<char>[] rows = new HashSet<char>[9];
                HashSet<char>[] cols = new HashSet<char>[9];
                HashSet<char>[] boxes = new HashSet<char>[9];

                // Initiera alla HashSets
                for (int i = 0; i < 9; i++)
                {
                    rows[i] = new HashSet<char>();
                    cols[i] = new HashSet<char>();
                    boxes[i] = new HashSet<char>();
                }

                // Loopa igenom varje cell på brädet (r = rad, c = kolumn)
                for (int r = 0; r < 9; r++)
                {
                    for (int c = 0; c < 9; c++)
                    {
                        char val = board[r][c];

                        // Om cellen är tom ('.'), hoppa över den
                        if (val == '.')
                        {
                            continue;
                        }

                        // --- 1. Kontrollera raden ---
                        // Om numret redan finns i hashsetet för denna rad: OGILTIG
                        if (rows[r].Contains(val))
                        {
                            return false;
                        }
                        rows[r].Add(val); // Lägg till för framtida kontroller

                        // --- 2. Kontrollera kolumnen ---
                        // Om numret redan finns i hashsetet för denna kolumn: OGILTIG
                        if (cols[c].Contains(val))
                        {
                            return false;
                        }
                        cols[c].Add(val);

                        // --- 3. Kontrollera 3x3-boxen ---
                        // Räkna ut vilket box-index (0-8) vi befinner oss i.
                        // Formeln för indexet är: (rad / 3) * 3 + (kolumn / 3)
                        int boxIndex = (r / 3) * 3 + (c / 3);

                        if (boxes[boxIndex].Contains(val))
                        {
                            return false;
                        }
                        boxes[boxIndex].Add(val);
                    }
                }

                // Om vi gått igenom hela brädet utan konflikter
                return true;
            }
        }
    }
}

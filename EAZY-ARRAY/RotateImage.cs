using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode1.EAZY_ARRAY
{
   public class RotateImage
    {
      
public class Solution
    {
        public void Rotate(int[][] matrix)
        {
            int n = matrix.Length;

            // Steg 1: Transponera matrisen
            // Vi itererar över diagonalen och byter plats på (i, j) och (j, i)
            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    int temp = matrix[i][j];
                    matrix[i][j] = matrix[j][i];
                    matrix[j][i] = temp;
                }
            }

            // Steg 2: Vänd på varje rad (Reverse)
            // Vi byter plats på elementen från början och slutet av raden in mot mitten
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n / 2; j++)
                {
                    int temp = matrix[i][j];
                    matrix[i][j] = matrix[i][n - 1 - j];
                    matrix[i][n - 1 - j] = temp;
                }
            }
        }
    }
}
}

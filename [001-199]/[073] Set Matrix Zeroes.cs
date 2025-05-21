/*
Last Solved: 21.05.25
Topics Utilised: Matrix, HashSet
Link: https://leetcode.com/problems/set-matrix-zeroes/description/
Time Complexity: O(m x n)
Space Complexity: O(m + n)
*/

public class Solution {
    public void SetZeroes(int[][] matrix) {
        if (matrix == null || matrix.Length == 0)
            return;

        // rows to affect
        HashSet<int> rs = new HashSet<int>();
        // columns to affect
        HashSet<int> cs = new HashSet<int>();

        // for each row
        for (int r = 0; r < matrix.Length; r++)
        {
            int[] row = matrix[r];

            // for each cell in this row
            for (int c = 0; c < row.Length; c++)
            {
                if (row[c] == 0)
                {
                    rs.Add(r);
                    cs.Add(c);
                }
            }
        }

        // for each rs to affect
        foreach (int r in rs)
        {
            // for each cell in matrix at this row
            for (int i = 0; i < matrix[r].Length; i++)
            {
                matrix[r][i] = 0;
            }
        }

        // for each cs to affect
        foreach (int c in cs)
        {
            // for row in matrix
            for (int i = 0; i < matrix.Length; i++)
            {
                // if c is in this array (e.g. if 2nd row has enough columns)
                if (c < matrix[i].Length)
                {
                    matrix[i][c] = 0;
                }
            }
        }
    }

}

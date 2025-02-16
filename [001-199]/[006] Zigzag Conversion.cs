/*
Last Solved: 16.02.25
Topics Utilised: Strings
Link: https://leetcode.com/problems/zigzag-conversion/
Time Complexity: O(n)
Space Complexity: O(n)
*/

public class Solution {
    public string Convert(string s, int numRows) {
        StringBuilder[] sb = new StringBuilder[numRows];

        // init the string builders
        for (int h = 0; h < numRows; h++){
            sb[h] = new StringBuilder();
        }

        int curRow = 0;
        bool isDescending = true;

        for (int i = 0; i < s.Length; i++){
            // ensure curRow never goes outside of it's bounds
            curRow = Math.Clamp(curRow, 0, numRows - 1);

            // add this char to the sb on the current row
            sb[curRow].Append(s[i]);

            // no diagonality (straight down)
            if (isDescending)
            {
                // at last row
                if (curRow == numRows - 1){
                    isDescending = false;

                    // go back(up) one in row (zigzag)
                    curRow--;
                }
                // can continue downwards
                else{
                    curRow++;
                }
            }
            // traversing back up diagonally
            else
            {
                // at first row
                if (curRow == 0){
                    isDescending = true;
                    curRow++;
                }
                // can continue upwards
                else{
                    curRow--;
                }
            }
        }

        // concat the string builder rows together
        StringBuilder res = new StringBuilder();
        for (int j = 0; j < numRows; j++){
            res.Append(sb[j]);
        }

        return res.ToString();
    }
}

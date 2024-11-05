/*
Last Solved: 27.10.24
Topics Utilised: Binary Search, Matrix
Link: https://leetcode.com/problems/search-a-2d-matrix/
Time Complexity: O(log(m * n))
Space Compelxity: O(1)
*/

public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int arrInd = -1;

        int l = 0;
        int r = matrix.Length - 1;
        int mid;

        //Select arr
        while (l <= r){
            mid = l + ((r - l) / 2);

            //If 1st in this arr is less than target (this arr only contains bigger)
            if (matrix[mid][0] > target){
                r = mid - 1;
            }
            //If last num in this arr is smaller (this arr only contains smaller)
            else if (matrix[mid][matrix[mid].Length - 1] < target){
                l = mid + 1;
            }
            //Target arr found, break loop
            else{
                arrInd = mid;
                break;
            }
        }

        if (arrInd == -1) 
            return false;

        l = 0;
        r = matrix[arrInd].Length - 1;
        while (l <= r){
            mid = l + ((r - l) / 2);

            //Num more than target
            if (matrix[arrInd][mid] > target){
                r = mid - 1;
            }
            //Num less than target
            else if (matrix[arrInd][mid] < target){
                l = mid + 1;
            }
            else{
                return true;
            }
        }

        return false;
    }
}

/*
Last Solved: 22.11.24
Topics Utilised: Arrays, 
Link: https://leetcode.com/problems/rotate-array/
Time Complexity: O(n) [Simplified from O(2n)]
Space Complexity: O(n) [Simplified from O(2n)]
*/

public class Solution {
    public void Rotate(int[] nums, int k) {
        // copy all values to an extra array
        int[] numsCopy = new int[nums.Length];
        Array.Copy(nums, numsCopy, nums.Length);

        // iterate through nums
        for (int i = 0; i < numsCopy.Length; i++)
        {
            int newInd = i + k;

            // if outside of the array length
            if (newInd > numsCopy.Length - 1)
            {
                // get the number of steps it overflows by
                newInd = newInd % numsCopy.Length;
            }
            // else it can be put in the array as is

            //store the value in the new ind in the new arr
            nums[newInd] = numsCopy[i];
        }
    }
}

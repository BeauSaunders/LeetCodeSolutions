/*
Last Solved: 23.10.24
Topics Utilised: Two Pointers
Link: https://leetcode.com/problems/remove-duplicates-from-sorted-array-ii/
Time Complexity: O(n)
Space Complexity: O(1)
*/

public class Solution {
    public int RemoveDuplicates(int[] nums) {
        //Start at 1 since the 0th index will always be unique
        int counter = 1;

        int l = 1;
        for (int r = 1; r < nums.Length; r++){
            //Same num as previous
            if (nums[r] == nums[r - 1]){
                counter++;
            }
            //Different num
            else{
                counter = 1;
            }

            //Valid num placement, move to 'l' to 'r'
            if (counter <= 2){
                nums[l] = nums[r];
                l++;
            }
        }

        //'l' points to the last index of valid nums
        return l;
    }
}

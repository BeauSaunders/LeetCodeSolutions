/*
Last Solved: 28.10.24
Topics Utilised: Two Pointers
Link: https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/
Time Complexity: O(n)
Space Complexity: O(1)
*/

public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int l = 0;
        int r = numbers.Length - 1;
        int curSum;
        while (l < r){
            curSum = numbers[l] + numbers[r];

            if (curSum == target)
                break;

            if (curSum > target){
                r--;
            }
            else if (curSum < target){
                l++;
            }
        }

        return new int[] {l + 1, r + 1};
    }
}

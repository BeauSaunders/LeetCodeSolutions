/*
Last Solved: 09.10.24
Topics Utilised: Two Pointers
Link: https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/
Time Complexity: O(n)
Space Complexity: O(1)
*/

public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int left = 0;
        int right = numbers.Length - 1;

        while (left < right){
            int sum = numbers[left] + numbers[right];

            //Sum of two values = target, return index of values in 1-indexed format
            if (sum == target)
                return new int[] {left + 1, right + 1};

            //Sum is not enough, increment left pointer (increase sum)
            if (sum < target)
                left++;

            //Sum is too much, decrease right pointer (decrease sum)
            else
                right--;
        }

        //No 2 indexes were found that add up to the target
        return null;
    }
}

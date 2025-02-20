/*
Last Solved: 20.02.25
Topics Utilised: Hash Table
Link: https://leetcode.com/problems/contains-duplicate-ii/
Time Complexity: O(n)
Space Complexity: O(n)
*/

public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        // val, ind
        Dictionary<int, int> dict = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++){
            // this number has already been seen
            if (dict.ContainsKey(nums[i])){
                // if ind already seen - this ind <= k
                if (Math.Abs(dict[nums[i]] - i) <= k)
                    return true;
            } 
            // else it was not yet seen
            // or
            // the gap was too big, update it to the closer one
            dict[nums[i]] = i;
        }

        return false;
    }
}

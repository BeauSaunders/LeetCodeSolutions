/*
Last Solved: 25.10.24
Topics Utilised: Hash Table
Link: https://leetcode.com/problems/two-sum/
Time Complexity: O(n)
Space Complexity: O(n)
*/

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        //Number, Index
        Dictionary<int, int> dict = new Dictionary<int, int>();
        
        for (int i = 0; i < nums.Length; i++)
        {
            //Number needed
            int diff = target - nums[i];

            //If number was previously seen
            if (dict.ContainsKey(diff)){
                //Return Index of needed num and current index
                return new int[]{dict[diff], i};
            }
            //Number not yet seen
            else{
                //Add current num and index
                dict.Add(nums[i], i);
            }
        }

        return null;
    }
}

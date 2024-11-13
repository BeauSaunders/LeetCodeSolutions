/*
Last Solved: 28.10.24
Topics Utilised: Two Pointers
Link: https://leetcode.com/problems/3sum/
Time Complexity: O(n²)
Space Complexity: O(k) [where k is the number of unique elements]
*/

public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        var res = new List<IList<int>>();

        int l = 0, r = nums.Length - 1, curSum;
        //Foreach number (leave two blank to have enough non duplicated values)
        for (int i = 0; i < nums.Length - 2; i++){
            //If not the first and same as the previous num, continue to avoid duplicates
            if (i > 0 && nums[i] == nums[i - 1])
                continue;

            l = i + 1;
            r = nums.Length - 1;
            while (l < r){
                curSum = nums[i] + nums[l] + nums[r];

                if (curSum == 0){
                    res.Add(new List<int>(){nums[i], nums[l], nums[r]});
                    l++;

                    //Keep shifting the l pointer if the number is the same as prev
                    while (l < r && nums[l] == nums[l - 1]){
                        l++;
                    }
                }

                //Too big
                if (curSum > 0){
                    r--;
                }
                //Too small
                else if (curSum < 0){
                    l++;
                }
            }
        }

        return res;
    }
}

/*
Last Solved: 25.10.24
Topics Utilised: Array
Link: https://leetcode.com/problems/can-place-flowers/
Time Complexity: O(n)
Space Complexity: O(1)
*/

public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {
        int available = 0;

        for (int i = 0; i < flowerbed.Length; i++){
            //If this planter has nothing
            if (flowerbed[i] == 0){
                //If not the first planter
                if (i > 0){
                    //If the bed to the right has a plant in, not valid
                    if (flowerbed[i - 1] == 1){
                        continue;
                    }
                }
                //If not the last planter
                if (i < flowerbed.Length - 1){
                    //bed to the right has a plant, not valid
                    if (flowerbed[i + 1] == 1){
                        continue;
                    }
                }
                
                available++;
                i++;
            }
        }
        
        if (available >= n) return true;
        else return false;
    }
}

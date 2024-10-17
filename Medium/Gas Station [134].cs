/*
Last Solved: 11.10.24
Topics Utilised: Greedy
Link: https://leetcode.com/problems/gas-station/
*/

public class Solution {
    public int CanCompleteCircuit(int[] gas, int[] cost) {
        //Not possible
        if (gas.Sum() < cost.Sum()) return -1;

        int totalGas = 0;
        int startInd = 0;
        for (int i = 0; i < gas.Length; i++){
            //Amount of gas in car when leaving this station to the next
            totalGas += gas[i] - cost[i];

            //If this movement results in having no fuel (overall), can't start here
            if (totalGas < 0){  
                totalGas = 0;
                startInd = i + 1;
            } 
        }

        return startInd;
    }
}

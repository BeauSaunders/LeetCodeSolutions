/*
Last Solved: 26.03.25
Topics Utilised: Math, Greedy Algorithm
Link: https://leetcode.com/problems/integer-replacement/
Time Complexity: O(log(n))
Space Complexity: O(1)
*/

public class Solution {
    public int IntegerReplacement(int n) {
        if (n == int.MaxValue)
            return 32;

        int steps = 0;

        while (n != 1){
            if (n % 2 == 0){
                n /= 2;
            }
            // special case
            // odd number above 3
            // 16 divides multiple times
            else if (n == 3 || (n + 1) % 4 != 0){
                n--;
            }
            else{
                n++;
            }

            steps++;
        }

        return steps;
    }
}

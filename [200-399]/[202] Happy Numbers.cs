/*
Last Solved: 07.12.24
Topics Utilised: HashSet, Math
Link: https://leetcode.com/problems/happy-number/
Time Complexity: O(log(n)) [as the iterations are based on n's digits (which are broken down and not repeated) it is logarithmic]
Space Complexity: O(log(n)) [as it won't repeat, storage is only increased with the amount of iterations]
*/

public class Solution {
    public bool IsHappy(int n) {
        int curN = n;
        HashSet<int> seenNums = new HashSet<int>();
        while (curN != 1)
        {
            // curN has already been this number, so it is an endless loop
            if (!seenNums.Add(curN))
            {
                return false;
            }

            // holds curN for digit extraction
            int tmpN = curN;

            // reset curN so we can to it from fresh
            curN = 0;
            while (tmpN > 0)
            {
                // extract the digit from num
                int digit = tmpN % 10;
                tmpN /= 10;

                // add the square of this digit to curN
                curN += digit * digit;
            }
        }

        return true;
    }
}

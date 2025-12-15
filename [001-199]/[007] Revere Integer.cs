/*
Last Solved: 15.12.25
Topics Utilised: Ints
Link: https://leetcode.com/problems/reverse-integer/
Time Complexity: O(n)
Space Complexity: O(1)
*/

public class Solution {
    public int Reverse(int x) {
        int r = 0, max = Int32.MaxValue / 10, min = Int32.MinValue / 10;

        // while the input still has digits
        while (x != 0)
        {
            // extra last digit
            int digit = x % 10;
            
            // positive overflow (if equal to and more than max last digit)
            if (r > max || r == max && digit > 7)
                return 0;
            // negative overflow
            else if (r < min || r == min && digit < -8)
                return 0;

            // divide the last digit off the input (% doesn't affect original)
            x /= 10;

            // result = result * 10 (to add a zero digit on the end) + digit
            r = r * 10 + digit;
        }

        return r;
    }
}

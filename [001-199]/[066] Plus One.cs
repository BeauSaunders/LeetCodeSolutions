/*
Last Solved: 27.01.25
Topics Utilised: Arrays, Integers
Link: https://leetcode.com/problems/plus-one/
Time Complexity: O(n)
Space Complexity: O(n)
*/

public class Solution {
    public int[] PlusOne(int[] digits) {
        // traverse digits in reverse
        for (int i = digits.Length - 1; i >= 0; i--){
            // if this digit is smaller than 9, it can be incremented in place
            if (digits[i] < 9)
            {
                digits[i]++;
                return digits;
            }
            // else this number is 9, if there is a digit before it
            else if (i - 1 >= 0)
            {
                digits[i] = 0; // set it to 0 to allow next digit to be incremented instead
            }
        }

        // if here, we ran out of digits, create a longer array
        int[] res = new int[digits.Length + 1];

        // set the first digit to 1 (since [1] would = 0)
        // all other digits would also be 0 to round up to this point
        res[0] = 1;

        return res;
    }
}

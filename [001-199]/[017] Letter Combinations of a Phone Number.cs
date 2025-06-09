/*
Last Solved: 09.06.25
Topics Utilised: Backtracking, Hash Table
Link: https://leetcode.com/problems/letter-combinations-of-a-phone-number/
Time Complexity: O(k^n) - where k = combinations & n = digits length
Space Complexity: O(k^n x n) - k^n for result list size & n for stack recursion and string building length
*/

public class Solution {
    public IList<string> LetterCombinations(string digits) {
        if (string.IsNullOrEmpty(digits))
            return new List<string>();

        // dictionary of array of chars (num, char[])
        Dictionary<string, string> dict = new Dictionary<string, string>{
            {"2", "abc"},
            {"3", "def"},
            {"4", "ghi"},
            {"5", "jkl"},
            {"6", "mno"},
            {"7", "pqrs"},
            {"8", "tuv"},
            {"9", "wxyz"}
        };

        List<string> result = new List<string>();

        // i = index of digits, curStr = string being built
        void Backtrack(int i, string curStr){
            // if reached the end of the digits for this string combo, return it
            if (curStr.Length == digits.Length)
            {
                // add this completed combo to the result list
                result.Add(curStr);
                return;
            }
            
            // get letters of this digit (would be a char, convert to stirng)
            string letters = dict[digits[i].ToString()];

            // for each character of this digit
            for (int c = 0; c < letters.Length; c++)
            {
                // backtrack from next digit, adding the new c to the str
                Backtrack(i + 1, curStr + letters[c]);
            }
        }

        Backtrack(0, "");

        return result;
    }
}

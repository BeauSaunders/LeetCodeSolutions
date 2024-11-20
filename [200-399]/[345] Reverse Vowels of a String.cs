/*
Last Solved: 20.11.24
Topics Utilised: Two Pointers, Strings
Link: https://leetcode.com/problems/reverse-vowels-of-a-string/
Time Complexity: O(n)
Space Complexity: O(n)
*/

public class Solution {
    public string ReverseVowels(string s) {
        // can't write individual chars of a string, so convert it to a char[]
        char[] chars = s.ToCharArray();

        int l = 0, r = s.Length - 1;
        while (l < r)
        {
            // increment l in until it finds a vowel
            while (l < r && !isVowel(chars[l]))
            {
                l++;
            }

            // move r in until it finds a vowel
            while (l < r && !isVowel(chars[r]))
            {
                r--;
            }

            // tmp char as it will be overwritten
            char lChar = chars[l];
            chars[l] = chars[r];
            chars[r] = lChar;

            // move pointers so it doesn't remain on the same vowel
            l++;
            r--;
        }

        return new string(chars);
    }

    bool isVowel(char c){
        c = Char.ToLower(c);
        return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u';
    }
}

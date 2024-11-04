/*
Last Solved: 04.11.24
Topics Utilised: String Builder
Link: https://leetcode.com/problems/removing-stars-from-a-string/
Time Complexity: O(n)
Space Complexity: O(n)
*/

public class Solution {
    public string RemoveStars(string s) {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < s.Length; i++){
            if (s[i] == '*'){
                //Remove the character before (& don't append the star)
                sb.Remove(sb.Length - 1, 1);
            }
            else{
                //Not a start, add it to the string
                sb.Append(s[i]);
            }
        }

        return sb.ToString();
    }
}

/*
Last Solved: 18.10.24
Topics Utilised: Hash Table
Link: https://leetcode.com/problems/isomorphic-strings/
Time Complexity: O(n)
Space Complexity: O(n)
*/

public class Solution {
    public bool IsIsomorphic(string s, string t) {
        if (s.Length != t.Length) return false;

        //Dict = s char -> t char
        Dictionary<char, char> chars = new Dictionary<char, char>();

        for (int i = 0; i < s.Length; i++){
            //If already tracked, check it matches
            if (chars.ContainsKey(s[i])){
                if (chars[s[i]] != t[i]) return false;
            }
            //If dict doesn't have key, see if t char exists
            else if (chars.ContainsValue(t[i])){
                return false;
            }
            //Else both key and value don't exist, add them
            else{
                chars.Add(s[i], t[i]);
            }
        }

        return true;
    }
}

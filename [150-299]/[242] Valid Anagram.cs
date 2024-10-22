/*
Last Solved: 22.10.24
Topics Utilised: Hash Table
Link: https://leetcode.com/problems/valid-anagram/
Time Complexity: O(n)
Space Complexity: O(n)
*/

public class Solution {
    public bool IsAnagram(string s, string t) {
        //Edge case
        if (s.Length != t.Length) return false;

        //Track the chars and amounts in 's'
        Dictionary<char, int> dict = new Dictionary<char, int>();
        for (int i = 0; i < s.Length; i++){
            char sChar = s[i];
            if (dict.ContainsKey(sChar)){
                dict[sChar] = dict[sChar] + 1;
            }
            else{
                dict.Add(sChar, 1);
            }
        }

        //Compare counts and chars against Hash Table
        for (int j = 0; j < t.Length; j++){
            char tChar = t[j];
            //If Hash Table doesn't contain this char, or they've all already been used
            if (!dict.ContainsKey(tChar) || dict[tChar] < 1){
                return false;
            }
            else{
                dict[tChar] = dict[tChar] - 1;
            }
        }

        return true;
    }
}

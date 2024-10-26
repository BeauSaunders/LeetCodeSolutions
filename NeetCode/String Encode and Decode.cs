/*
Last Solved: 26.10.24
Topics Utilised: Lists, StringBuilder
Link: https://neetcode.io/problems/string-encode-and-decode
Time Complexity: O(n)
Space Complexity: O(n)
*/

public class Solution {

    public string Encode(IList<string> strs) {
        int len = strs.Count();
        if (len <= 0) return null;

        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < len; i++){
            sb.Append(strs[i]);
            if (i < len - 1){
                sb.Append(";");
            }  
        }

        return sb.ToString();
    }

    public List<string> Decode(string s) {
        if (s == null) return new List<string>();

        return s.Split(";").ToList();
   }
}

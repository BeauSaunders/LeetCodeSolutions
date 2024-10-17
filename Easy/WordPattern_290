public class Solution {
    public bool WordPattern(string pattern, string s) {
        string[] words = s.Split(' ');

        //Not enough words to match the pattern
        if (pattern.Length != words.Length) return false;

        Dictionary<char, string> defs = new Dictionary<char, string>();
        for (int i = 0; i < pattern.Length; i++){
            //Not already defined
            if (!defs.ContainsKey(pattern[i])){
                //Word is already mapped to another char - Pattern mismatch
                if (defs.ContainsValue(words[i])) return false;

                defs.Add(pattern[i], words[i]);
            }
            //Already in dictionary
            else{
                if (defs[pattern[i]] != words[i]) return false;
            }
        }

        return true;
    }
}

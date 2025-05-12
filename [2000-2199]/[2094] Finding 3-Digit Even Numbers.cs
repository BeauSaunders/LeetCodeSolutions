/*
Last Solved: 12.05.25
Topics Utilised: HashSet, 
Link: https://leetcode.com/problems/finding-3-digit-even-numbers/description/
Time Complexity: O(n³)
Space Complexity: O(1) -> hashset will never contain more than 450 results (even numbers between 100 -> 998)
*/

public class Solution {
    public int[] FindEvenNumbers(int[] digits) {
        if (digits == null || digits.Length < 3)
            return null;

        // unique combinations
        HashSet<int> res = new HashSet<int>();

        // iterate each digit (all combinations)
        for (int i = 0; i < digits.Length; i++)
        {
            // leading 0
            if (digits[i] == 0)
                continue;

            for (int j = 0; j < digits.Length; j++)
            {
                for (int k = 0; k < digits.Length; k++)
                {
                    // don't allow duplicates
                    if (i == j || j == k || i == k)
                        continue;

                    int dOne = digits[i];
                    int dTwo = digits[j];
                    int dThree = digits[k];

                    // even check
                    if (dThree % 2 != 0)
                        continue;

                    // concat into a 3 digit int
                    int num = dOne * 100 + dTwo * 10 + dThree;

                    // hashset = only adds if unique
                    res.Add(num);
                }
            }
        }

        // sort the results
        List<int> sorted = res.ToList();
        sorted.Sort();

        // return as an int[]
        return sorted.ToArray();
    }
}

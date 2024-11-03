/*
Last Solved: 03.11.24
Topics Utilised: Stack, Math
Link: https://leetcode.com/problems/evaluate-reverse-polish-notation/
Time Complexity: O(n)
Space Complexity: O(n)
*/


public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> nums = new Stack<int>();

        for (int i = 0; i < tokens.Length; i++){
            //If it is an int
            if (Int32.TryParse(tokens[i], out int num)){
                nums.Push(num);
            }
            //It is an operator
            else{
                //Get the last 2 nums
                int num1 = nums.Pop();
                int num2 = nums.Pop();

                //Perform operation (switch num1/num2 pos to calculate correctly)
                int res = 0;
                switch (tokens[i]){
                    case "+":
                        res = num2 + num1;
                        break;
                    case "-":
                        res = num2 - num1;
                        break;
                    case "*":
                        res = num2 * num1;
                        break;
                    case "/":
                        res = num2 / num1;
                        break;
                }

                //Add the result to the stack so it can be used on the next run
                nums.Push(res);
            }
        }
        
        //Stack is left with 1 num (the result)
        return nums.Pop();
    }
}

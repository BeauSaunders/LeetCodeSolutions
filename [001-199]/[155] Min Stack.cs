/*
Last Solved: 30.10.24
Topics Utilised: Stack
Link: https://leetcode.com/problems/min-stack/
Time Complexity: O(1)
Space Complexity: O(n)
*/

public class MinStack {

    Stack<int> stack = new Stack<int>();
    Stack<int> minStack = new Stack<int>();

    public MinStack() {
        stack.Clear();
    }
    
    public void Push(int val) {
        stack.Push(val);

        int newMin;
        if (minStack.Count > 0){
            newMin = Math.Min(minStack.Peek(), val);
        }
        else{
            newMin = val;
        }
        
        minStack.Push(newMin);
    }
    
    public void Pop() {
        stack.Pop();
        minStack.Pop();
    }
    
    public int Top() {
        return stack.Peek();
    }
    
    public int GetMin() {
        return minStack.Peek();
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(val);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */

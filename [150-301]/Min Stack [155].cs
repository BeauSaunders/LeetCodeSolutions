/*
Last Solved: 21.10.24
Topics Utilised: Lists, Stacks
Link: https://leetcode.com/problems/min-stack/
Time Complexity: O(1)
Space Complexity: O(n)
*/

public class MinStack {
    //Can't easily append to arrays in c#, so use lists
    //Holds the pushed/popped values
    List<int> stack = new List<int>();
    //Contains the min val at each index
    List<int> minStackTrack = new List<int>();

    public MinStack() {
        stack.Clear();
    }
    
    public void Push(int val) {
        stack.Add(val);

        int currentMin;
        //No min val for 0th push
        if (minStackTrack.Count == 0){ 
            currentMin = Int32.MaxValue;
        }
        //Get current min from stack
        else{
            currentMin = minStackTrack[minStackTrack.Count - 1];
        }
        
        //Update min if it is smaller
        if (val < currentMin) {
            minStackTrack.Add(val);
        }
        //Else continue with the current min
        else{
            minStackTrack.Add(currentMin);
        }
    }
    
    //Remove the top index
    public void Pop() {
        int ind = stack.Count - 1;
        stack.RemoveAt(ind);
        minStackTrack.RemoveAt(ind);
    }
    
    //View the top index
    public int Top() {
        return stack[stack.Count - 1];
    }
    
    //Return the top index of the min stack (stores whatever the current min is at this index)
    public int GetMin() {
        return minStackTrack[minStackTrack.Count - 1];
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

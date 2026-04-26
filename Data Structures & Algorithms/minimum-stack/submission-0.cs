public class MinStack {

    Stack<int> stack;
    Stack<int> minPref;

    public MinStack() {
        this.stack = new Stack<int>();
        this.minPref = new Stack<int>();
    }
    
    public void Push(int val) {
        stack.Push(val);
        if (minPref.Count == 0 || val <= minPref.Peek()) {
            minPref.Push(val);
        }
    }
    
    public void Pop() {
        int popped = stack.Pop();
        if (popped == minPref.Peek()) {
            minPref.Pop();
        }
    }
    
    public int Top() {
        return stack.Peek();
    }
    
    public int GetMin() {
        return minPref.Peek();
    }
}

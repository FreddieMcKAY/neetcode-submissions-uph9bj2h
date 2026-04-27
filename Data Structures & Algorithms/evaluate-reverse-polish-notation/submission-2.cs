public class Solution {
    public int EvalRPN(string[] tokens) {

        Stack<int> stack = new Stack<int>();

        foreach (string str in tokens) {

            int one;

            switch(str)
            {
                case "+":
                    one = stack.Pop();
                    stack.Push(stack.Pop() + one);
                    break;
                case "-":
                    one = stack.Pop();
                    stack.Push(stack.Pop() - one);
                    break;
                case "*":
                    one = stack.Pop();
                    stack.Push(stack.Pop() * one);
                    break;
                case "/":
                    one = stack.Pop();
                    stack.Push(stack.Pop() / one);
                    break;
                default:
                    stack.Push(Int32.Parse(str));
                    break;
            }

        }

        return stack.Pop();
        
    }
}

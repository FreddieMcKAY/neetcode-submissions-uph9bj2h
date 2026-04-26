public class Solution {
    public bool IsValid(string s) {

        var stack = new Stack<char>();
        var map = new Dictionary<char, char> {
            {')', '('},
            {'}', '{'},
            {']', '['}
        };

        foreach (char c in s) {

            // If its closing, pop from stack and check against map
            if (map.ContainsKey(c)) {
                if (stack.Count == 0 || stack.Pop() != map[c]) {
                    return false;
                }
            }
            // Else, add to the stack
            else {
                stack.Push(c);
            }
        }
        // If valid, all brackets should be removed.
        return stack.Count == 0;
    }
}

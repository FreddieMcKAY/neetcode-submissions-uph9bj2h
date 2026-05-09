public class Solution {
    public int LargestRectangleArea(int[] heights) {

        int max = 0;
        int l = heights.Length;

        Stack<int[]> stack = new Stack<int[]>();

        for (int i = 0; i < l; i++) {

            int idx = i;
            int height = heights[i];

            while (stack.Count > 0 && height < stack.Peek()[1]) {
                int[] comp = stack.Pop();
                idx = comp[0];
                int pot = comp[1] * (i - comp[0]);
                max = Math.Max(max, pot);
            }
            stack.Push([idx, heights[i]]);
        }

        while (stack.Count > 0) {
            int[] comp = stack.Pop();
            int pot = comp[1] * (l - comp[0]);
            max = Math.Max(max, pot);
        }

        return max;

    
    }
}

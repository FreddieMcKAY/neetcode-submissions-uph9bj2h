public class Solution {
    public int MaxArea(int[] heights) {

        int max = 0;
        int l = 0;
        int r = heights.Length - 1;

        while (l < r) {

            int top = Math.Min(heights[l], heights[r]);
            max = Math.Max(max, (r - l) * top);

            if (heights[r] > heights[l]) {
                l++;
            } else {
                r--;
            }

        }

        return max;
        
    }
}

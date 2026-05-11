public class Solution {
    public int MaxProfit(int[] prices) {

        int l = 0;
        int r = 1;
        int h = 0;

        while (r < prices.Length) {
            if (prices[l] < prices[r]) h = Math.Max(h, prices[r] - prices[l]);
            else l = r;
            r++;
        }

        return h;
    }
}

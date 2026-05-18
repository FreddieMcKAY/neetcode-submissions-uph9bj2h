public class Solution {
    public int MaxProfit(int[] prices) {

        int res = 0;
        int current = prices[prices.Length - 1];
        int max = 0;

        for (int i = prices.Length - 2; i >= 0; i--) {
            if (prices[i] < prices[i + 1]) {
                int tmp = current - prices[i];
                max = Math.Max(max, tmp);
            } else {
                res += max;
                max = 0;
                current = prices[i];
            }
        }
        res += max;
        return res;
        
    }
}
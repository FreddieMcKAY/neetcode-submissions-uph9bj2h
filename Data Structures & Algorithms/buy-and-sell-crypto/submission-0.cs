public class Solution {
    public int MaxProfit(int[] prices) {

        int lowest = prices[0];
        int highest = 0;

        for (int i = 1; i < prices.Length; i++) {
            if (prices[i] < lowest) lowest = prices[i];
            else highest = Math.Max(highest, prices[i] - lowest);
        }

        return highest;
    }
}

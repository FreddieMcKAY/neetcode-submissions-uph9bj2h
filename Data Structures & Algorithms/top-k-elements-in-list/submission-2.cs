public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {

        Dictionary<int, int> counts = new Dictionary<int, int>();

        int[] res = new int[k];

        // Count frequencies by incrementing values in dictionary keys

        foreach (int num in nums) {

            if (!counts.ContainsKey(num)) {
                counts[num] = 0;
            }
            counts[num]++;
        }

        // Sort counts by key count

        var sorted = counts.OrderByDescending(kvp => kvp.Value).ToList();
        
        // Set res indexs to first k item.Keys in sorted counts
        for (int i = 0; i < k; i++)
        {
            res[i] = sorted[i].Key;
        }

        // Resturn result
        return res;
        
    }
}

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

        // Create buckets for possible counts

        List<int>[] buckets = new List<int>[nums.Length + 1];

        foreach (var kvp in counts) {

            int num = kvp.Value;
            int key = kvp.Key;

            if (buckets[num] == null) {
                buckets[num] = new List<int>();
            }
            buckets[num].Add(key);
        }

        // Track index, loop through buckets in reverse and set res[index] to nums
        // Increment index each time, return when index exceeds res length (k)

        int index = 0;
        
        for (int i = buckets.Length - 1; i >= 0; i--) {
            if (buckets[i] != null) {
                foreach (int num in buckets[i]) {
                    res[index] = num;
                    index++;
                    if (index == k) {
                       return res; 
                    }
                }
            }
        }
        return res;
    }
}

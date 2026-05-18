public class Solution {
    public List<int> MajorityElement(int[] nums) {
        
        var counts = new Dictionary<int, int>();
        var res = new List<int>();

        foreach (int num in nums) {
            if (!counts.ContainsKey(num)) {
                counts.Add(num, 0);
            }
            counts[num]++;
        }

        foreach(KeyValuePair<int, int> kvp in counts) {
            if (kvp.Value > nums.Length / 3) {
                res.Add(kvp.Key);
            }
        }

        return res;
        
    }
}
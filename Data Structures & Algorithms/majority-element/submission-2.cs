public class Solution {
    public int MajorityElement(int[] nums) {

        Dictionary<int, int> counts = new Dictionary<int, int>();
        int majority = nums.Length / 2;

        foreach (int n in nums) {

            if (!counts.ContainsKey(n)) {
                counts.Add(n, 0);
            }
            counts[n]++;

            if (counts[n] > majority) {
                return n;
            }
        }

        return nums[0];
        
    }
}
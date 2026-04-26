public class Solution {
    public int LongestConsecutive(int[] nums) {

        if (nums.Length == 0) {
            return 0;
        }

        HashSet<int> numbers = new HashSet<int>();
        List<int> heads = new List<int>();
        int max = 1;

        foreach (int num in nums) {
            if (!numbers.Contains(num)) {
                numbers.Add(num);
            }
        }

        for (int i = 0; i < nums.Length; i++) {
            if (!numbers.Contains(nums[i] - 1)) {
                heads.Add(nums[i]);
            }
        }

        foreach (int num in heads) {
            int count = 1;
            bool ended = false;
            int next = num + 1;

            while (!ended) {
                if (numbers.Contains(next)) {
                    count++;
                    next++;
                } else {
                    ended = true;
                }
            }

            max = Math.Max(max, count);
        }
        return max;
    }
}

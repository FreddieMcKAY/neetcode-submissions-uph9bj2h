public class Solution {
    public int[] TwoSum(int[] numbers, int target) {

        Dictionary<int, int> seen = new Dictionary<int, int>();

        for (int i = 0; i < numbers.Length; i++) {
            int comp = target - numbers[i];

            if (seen.ContainsKey(comp)) {
                return new int[] {seen[comp], i + 1};
            }

            seen.Add(numbers[i], i + 1);
        }

        return new int[] {0, 1};
        
    }
}

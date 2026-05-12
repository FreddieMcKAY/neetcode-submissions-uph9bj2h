public class Solution {
    public int RemoveElement(int[] nums, int val) {

        List<int> numbers = new List<int>();

        foreach (int n in nums) {
            if (n != val) {
                numbers.Add(n);
            }
        }

        for (int i = 0; i < numbers.Count; i++) {
            nums[i] = numbers[i];
        }

        return numbers.Count;
        
    }
}
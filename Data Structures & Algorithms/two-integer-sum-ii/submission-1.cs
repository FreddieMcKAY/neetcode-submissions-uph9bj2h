public class Solution {
    public int[] TwoSum(int[] numbers, int target) {

        int l = 0; int r = numbers.Length - 1;

        while (l < r) {
            int c = numbers[l] + numbers[r];
            if (c > target) {
                r--;
            } 
            else if (c < target) {
                l++;
            }
            else if (c == target) {
                return new int[] {l + 1, r + 1};
            }
        }
        return new int[0];
    }
}

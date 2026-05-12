public class Solution {
    public int[] SortArray(int[] nums) {

        if (nums.Length <= 1) return nums;

        int mid = nums.Length / 2;
        int[] left = nums[..mid];
        int[] right = nums[mid..];

        int[] sortedLeft = SortArray(left);
        int[] sortedRight = SortArray(right);

        return merge(sortedLeft, sortedRight);

    }

    public int[] merge(int[] left, int[] right) {

        int[] res = new int[left.Length + right.Length];
        int i = 0, j = 0, k = 0;

        while (i < left.Length && j < right.Length) {
            if (left[i] < right[j]){
                res[k] = left[i];
                i++;
            } else {
                res[k] = right[j];
                j++;
            }
            k++;
        }
        while (i < left.Length) {
            res[k] = left[i];
            i++;
            k++;
        }
        while (j < right.Length) {
            res[k] = right[j];
            j++;
            k++;
        }

        return res;
    }
}
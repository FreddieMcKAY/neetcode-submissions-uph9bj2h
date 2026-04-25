public class Solution {
    public int[] ProductExceptSelf(int[] nums) {

        int arrLength = nums.Length;

        int[] pre = new int[arrLength];
        int[] pos = new int[arrLength];
        int[] res = new int[arrLength];

        int product = 1;

        for (int i = 0; i < arrLength; i++) {
            product = product * nums[i];
            pre[i] = product;
        }
        
        product = 1;

        for (int j = arrLength - 1; j > -1; j--) {
            product = product * nums[j];
            pos[j] = product;
        }

        for (int k = 0; k < arrLength; k++) {
            int prev = k - 1;
            int next = k + 1;

            if (prev < 0) {
                res[k] = pos[next];
                continue;
            }
            if (next > arrLength - 1) {
                res[k] = pre[prev];
                continue;
            }

            res[k] = pre[prev] * pos[next];
        }
        
        return res;
    }
}

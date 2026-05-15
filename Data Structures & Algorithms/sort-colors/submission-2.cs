public class Solution {
    public void SortColors(int[] nums) {

        int red = 0;
        int white = 0;
        int blue = 0;
        int pointer = 0;

        foreach (int num in nums) {
            if (num == 0) {
                red++;
            } else if (num == 1) {
                white++;
            } else {
                blue++;
            }
        }

        while (red > 0) {
            nums[pointer] = 0;
            red--;
            pointer++;
        }

        while (white > 0) {
            nums[pointer] = 1;
            white--;
            pointer++;
        }

        while (blue > 0) {
            nums[pointer] = 2;
            blue--;
            pointer++;
        }
        
    }
}
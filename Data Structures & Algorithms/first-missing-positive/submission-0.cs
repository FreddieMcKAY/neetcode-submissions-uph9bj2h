public class Solution {
    public int FirstMissingPositive(int[] nums) {

        var set = new HashSet<int>(nums);

        for (int i = 1; i < ((2^31)-1); i++) {
            if (!set.Contains(i)) {
                return i;
            }
        }
        return -1;
        
    }
}
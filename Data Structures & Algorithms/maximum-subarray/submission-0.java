class Solution {
    public int maxSubArray(int[] nums) {

        int currentSum = 0;
        int maxSub = nums[0];

        for(int num : nums) {
            
            currentSum += num;
            maxSub = Math.max(currentSum, maxSub);
            
            if (currentSum < 0) {
                currentSum = 0;
            }
        }

        return maxSub;
        
    }
}

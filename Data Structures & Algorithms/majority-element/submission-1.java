class Solution {
    public int majorityElement(int[] nums) {

        Map<Integer, Integer> numCount = new HashMap<>();
        int res = 0, maxCount = 0;

        for(int num : nums) {
            numCount.put(num, numCount.getOrDefault(num, 0) + 1);
            
            if(numCount.get(num) > maxCount) {
                res = num;
                maxCount = numCount.get(num);
            }

            
        }

        return res;
        
    }
}
class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:

        seen = {key: idx for idx, key in enumerate(nums)}

        for i in range(0, len(nums)):
            complement = target - nums[i]
            if complement in seen and seen[complement] != i:
                return [i, seen[complement]]
        
        return [0, 0]
            
        
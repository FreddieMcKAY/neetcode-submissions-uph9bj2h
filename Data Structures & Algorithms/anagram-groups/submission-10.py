class Solution:
    def groupAnagrams(self, strs: List[str]) -> List[List[str]]:

        output = defaultdict(list)

        for str in strs:
            letterCounts = [0] * 26

            for c in str:
                letterCounts[ord(c) - ord('a')] += 1

            output[tuple(letterCounts)].append(str)
            

        return list(output.values())

            

        
        

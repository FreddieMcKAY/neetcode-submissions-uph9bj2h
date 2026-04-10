class Solution:
    def longestCommonPrefix(self, strs: List[str]) -> str:

        longest = ""
        current = ''
        idx = 0

        while idx <= 200:
            if len(strs[0]) > idx:
                current = strs[0][idx]
            else:
                return longest

            for s in strs:
                if len(s) > idx:
                    if s[idx] != current:
                        return longest
                else:
                    return longest

                

            longest = longest + current
            idx = idx + 1
    

        
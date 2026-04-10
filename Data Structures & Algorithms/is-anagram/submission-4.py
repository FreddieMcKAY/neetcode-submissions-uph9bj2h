class Solution:
    def isAnagram(self, s: str, t: str) -> bool:

        if len(s) != len(t):
            return False

        seen = []
        for l in s:
            seen.append(l) 

        for i in t:
            if i in seen:
                seen.remove(i)
            else: 
                return False

        return True
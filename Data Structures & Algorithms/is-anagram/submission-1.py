class Solution:
    def isAnagram(self, s: str, t: str) -> bool:

        if len(s) != len(t):
            return False

        remaining = s

        for l in t:
            if s.count(l) == t.count(l):
                s.replace(l, "")
            else:
                return False
        
        return True
        
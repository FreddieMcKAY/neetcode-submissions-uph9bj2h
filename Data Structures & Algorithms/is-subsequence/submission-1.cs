public class Solution {
    public bool IsSubsequence(string s, string t) {

        if (s == null || s.Length == 0) {
            return true;
        }

        int sPointer = 0;
        int tPointer = 0;

        while (sPointer < s.Length && tPointer < t.Length) {
            
            if (s[sPointer] == t[tPointer]) {
                sPointer++;
            }
            tPointer++;

            if (sPointer == s.Length) {
                return true;
            }
        }

        return false;
        
    }
}
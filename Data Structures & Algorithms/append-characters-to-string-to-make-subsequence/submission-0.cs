public class Solution {
    public int AppendCharacters(string s, string t) {
        
        int tPointer = 0;
        int sPointer = 0;

        while (sPointer < s.Length && tPointer < t.Length) {
            if (s[sPointer] == t[tPointer]) {
                tPointer++;
            }
            sPointer++;
        }

        return t.Length - tPointer;
    }
}
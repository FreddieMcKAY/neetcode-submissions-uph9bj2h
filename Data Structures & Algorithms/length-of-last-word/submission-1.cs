public class Solution {
    public int LengthOfLastWord(string s) {

        int current = 0;

        for (int i = s.Length - 1; i >= 0 ; i--) {
            if (current > 0) {
                if (s[i] == ' ') {
                    return current;
                } else {
                    current++;
                    continue;
                }
            } else {
                if (s[i] == ' ') {
                    continue;
                } else {
                    current++;
                    continue;
                }
            }
        }

        return current;
        
    }
}
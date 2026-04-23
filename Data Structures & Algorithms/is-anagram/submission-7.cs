public class Solution {
    public bool IsAnagram(string s, string t) {

        if (s.Length != t.Length) {
            return false;
        }

        int[] charCount = new int[26];

        for (int i = 0; i < s.Length; i++) {
            int idx = char.ToLower(s[i]) - 'a';
            charCount[idx]++;
        }

        for (int j = 0; j < t.Length; j++) {
            int idx = char.ToLower(t[j]) - 'a';
            charCount[idx]--;
        }

        for (int k = 0; k < charCount.Length; k++) {
            if (charCount[k] != 0) {
                return false;
            }
        }

        return true;

    }
}

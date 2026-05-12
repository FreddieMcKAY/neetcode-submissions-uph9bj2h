public class Solution {
    public string LongestCommonPrefix(string[] strs) {

        String res = "";
        int idx = 0;

        while (idx <= 200) {

            char current;

            if (strs[0].Length > idx) {
                current = strs[0][idx];
            } else {
                return res;
            }

            foreach (String s in strs) {
                if (s.Length > idx && s[idx] == current) {
                    continue;
                }
                return res;
            }
            res += current;
            idx++;
            
        }
        return res;
      
    }
}
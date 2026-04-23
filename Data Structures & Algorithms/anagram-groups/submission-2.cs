public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {

        Dictionary<string, List<string>> anagrams = new Dictionary<string, List<string>>();

        foreach (string str in strs) {

            int[] letterCounts = new int[26];

            foreach (char c in str) {
                letterCounts[c - 'a']++;
            }

            string key = string.Join(",", letterCounts);

            if (!anagrams.ContainsKey(key))
            {
                anagrams[key] = new List<string>();
            }
            anagrams[key].Add(str);
        }

        return new List<List<string>>(anagrams.Values);
        
    }
}

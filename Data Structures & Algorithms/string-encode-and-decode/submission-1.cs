public class Solution {

    public string Encode(IList<string> strs) {

        StringBuilder sb = new StringBuilder();

        foreach (string str in strs) {
            sb.Append(str.Length + "#" + str);
        }

        return sb.ToString();
    }

    public List<string> Decode(string s) {

        char[] charArray = s.ToCharArray();
        List<string> words = new List<string>();
        int sIndex = 0;

        while (sIndex < charArray.Length) {
            
            StringBuilder currentWordCounter = new StringBuilder();

            for (int i = sIndex; i < s.Length; i++) {
                if (charArray[i] != '#') {
                    currentWordCounter.Append(charArray[i]);
                    sIndex++;
                } else {
                    break;
                }
            }
            sIndex++;
            int counter = Int32.Parse(currentWordCounter.ToString());
            int end = counter + sIndex;
            StringBuilder nw = new StringBuilder();

            for (int i = sIndex; i < end; i++) {
                nw.Append(charArray[i]);
                sIndex++;
            }
            words.Add(nw.ToString());
        }

        return words;

   }
}

public class Solution {
    public bool IsPalindrome(string s) {

        string str = Regex.Replace(s, "[^a-zA-Z0-9]", String.Empty).ToLower();

        Console.WriteLine(str);

        int left = 0;
        int right = str.Length - 1;

        while (left < right) {
            if (str[left] != str[right]) {
                return false;
            }
            left++;
            right--;
        }
        return true;
        
    }
}

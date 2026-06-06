public class Solution {
    public void ReverseString(char[] s) {

        if (s.Length < 2) {
            return;
        }

        int left = 0;
        int right = s.Length - 1;

        while (left < right) {
            char temp = s[right];
            s[right] = s[left];
            s[left] = temp;
            left++;
            right--;
        }
        
    }
}
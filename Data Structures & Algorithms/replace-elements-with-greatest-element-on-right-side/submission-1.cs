public class Solution {
    public int[] ReplaceElements(int[] arr) {

        int[] res = new int[arr.Length];
        int greatest = -1;

        for (int i = res.Length - 1; i >= 0; i--) {
            int current = arr[i];
            res[i] = greatest;
            greatest = Math.Max(greatest, current);
        }    

        return res;    
    }
}
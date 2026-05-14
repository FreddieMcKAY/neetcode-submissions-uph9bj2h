public class Solution {
    public int[] ReplaceElements(int[] arr) {

        int[] res = new int[arr.Length];
        int greatest = arr[arr.Length - 1];
        res[arr.Length - 1] = -1;

        for (int i = res.Length - 2; i >= 0; i--) {
            int current = arr[i];
            res[i] = greatest;
            greatest = Math.Max(greatest, current);
        }    

        return res;    
    }
}
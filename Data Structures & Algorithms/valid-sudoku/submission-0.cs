public class Solution {
    public bool IsValidSudoku(char[][] board) {

        Dictionary<int, HashSet<char>> rows = new();
        Dictionary<int, HashSet<char>> columns = new();
        Dictionary<int, HashSet<char>> boxs = new();

        for (int i = 0; i < 9; i++) {
            rows[i] = new HashSet<char>();
            columns[i] = new HashSet<char>();
            boxs[i] = new HashSet<char>();
        }

        for (int r = 0; r < 9; r++) {

            for (int c = 0; c < 9; c++) {

                int b = (r / 3) * 3 + (c / 3);
                char n = board[r][c];

                if (n == '.'){continue;}

                if (rows[r].Contains(n) || columns[c].Contains(n) || boxs[b].Contains(n)) {
                    return false;
                } else {
                    rows[r].Add(n);
                    columns[c].Add(n);
                    boxs[b].Add(n);
                }
            }
        }

        return true;
        
    }
}

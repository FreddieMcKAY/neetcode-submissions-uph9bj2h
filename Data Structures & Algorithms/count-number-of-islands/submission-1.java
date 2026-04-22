class Solution {
    public int numIslands(char[][] grid) {

        int rows = grid.length; int cols = grid[0].length;

        int count = 0;

        for (int r = 0; r < rows; r++) {
            for (int c = 0; c < cols; c++) {
                if (grid[r][c] == '1') {
                    dfs(grid, rows, cols, r, c);
                    count++;
                }
            }
        }

        return count;

        
    }
    private void dfs(char[][] grid, int rows, int cols, int row, int col) {
            if (row < 0 || row >= rows || col < 0 || col >= cols || grid[row][col] != '1') {
                return;
            } else {
              grid[row][col] = '0';
                dfs(grid, rows, cols, row, col + 1);
                dfs(grid, rows, cols, row + 1 ,col);
                dfs(grid, rows, cols, row - 1, col);
                dfs(grid, rows, cols, row, col - 1);  
            }
            
        }
}

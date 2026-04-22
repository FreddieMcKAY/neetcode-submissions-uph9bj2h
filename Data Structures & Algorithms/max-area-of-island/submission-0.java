class Solution {
    public int maxAreaOfIsland(int[][] grid) {

        int rows = grid.length; int cols = grid[0].length;
        int maxIsland = 0;

        for (int r = 0; r < rows; r++) {
            for (int c = 0; c < cols; c++) {
                if (grid[r][c] == 1) {
                    maxIsland = Math.max(maxIsland, dfs(grid, r, c));
                }
            }
        }

        return maxIsland;
        
    }

    private int dfs(int[][] grid, int r, int c) {

        if (r < 0 || r >= grid.length || c < 0 || c >= grid[0].length || grid[r][c] == 0) {
            return 0;
        } else {
            grid[r][c] = 0;
            int res = 1;
            res += dfs(grid, r + 1, c);
            res += dfs(grid, r, c + 1);
            res += dfs(grid, r - 1, c);
            res += dfs(grid, r, c - 1);
            return res;
        }

        
    }
}

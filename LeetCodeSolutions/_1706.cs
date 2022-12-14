namespace LeetCodeSolutions
{
    public class _1706
    {
        public static int[] FindBall(int[][] grid)
        {
            int maxRow = grid.Length;
            int maxCol = grid[0].Length;
            int[] balls = new int[maxCol];
            for (int i = 0; i < maxCol; i++)
            {
                balls[i] = i;
                for (int row = 0; row < maxRow; row++)
                {
                    if (balls[i] != -1) //Not stuck
                    {
                        if ((grid[row][balls[i]] == 1 && balls[i] == maxCol - 1) ||
                            (grid[row][balls[i]] == -1 && balls[i] == 0)) //Wall stuck
                        {
                            balls[i] = -1;
                            break;
                        }
                        else if (grid[row][balls[i]] == -1 && balls[i] > 0 &&
                                 grid[row][balls[i] - 1] == 1) //Stuck left
                        {
                            balls[i] = -1;
                            break;
                        }
                        else if (grid[row][balls[i]] == 1 && balls[i] < maxCol - 1 &&
                                 grid[row][balls[i] + 1] == -1) //Stuck right
                        {
                            balls[i] = -1;
                            break;
                        }
                        else
                        {
                            balls[i] += grid[row][balls[i]]; //Ends up at
                        }
                    }
                }
            }
            return balls;
        }
        public static int[] FindBallFaster(int[][] grid)
        {
            int maxRow = grid.Length;
            int maxCol = grid[0].Length;
            int[] balls = new int[maxCol];
            for (int i = 0; i < maxCol; i++)
            {
                int col = i;
                int row = 0;
                while (row < maxRow)
                {
                    if (grid[row][col] == 1 && col + 1 < maxCol && grid[row][col + 1] == 1)
                    {
                        row++;
                        col++;
                    }
                    else if (grid[row][col] == -1 && col - 1 >= 0 && grid[row][col - 1] == -1)
                    {
                        row++;
                        col--;
                    }
                    else
                    {
                        break;
                    }
                }
                balls[i] = row == maxRow ? col : -1;
            }
            return balls;
        }
        public static int[] FindBallAnother(int[][] grid)
        {
            int maxRow = grid.Length;
            int maxCol = grid[0].Length;
            int[] res = new int[maxCol];
            for (int i = 0; i < maxCol; ++i)
            {
                int from = i, to;
                for (int row = 0; row < maxRow; ++row)
                {
                    to = from + grid[row][from];
                    if (to < 0 || to >= maxCol || grid[row][to] != grid[row][from])
                    {
                        from = -1;
                        break;
                    }
                    from = to;
                }
                res[i] = from;
            }
            return res;
        }
    }
}
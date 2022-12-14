namespace LeetCodeSolutions
{
    public class _36
    {
        public bool IsValidSudoku(char[][] board)
        {
            int length = board.Length;
            var set = new HashSet<char>();
            //Gå igenom top rad och kolla om duplikater finns i kolumnen
            for (int rad = 0; rad < length; rad++)
            {
                set.Clear();
                for (int kol = 0; kol < length; kol++)
                {
                    if (board[rad][kol] != '.' && !set.Add(board[rad][kol]))
                    {
                        return false;
                    }
                }
            }
            //Gå igenom vänster kolumn, kolla om duplikater i raden
            for (int kol = 0; kol < length; kol++)
            {
                set.Clear();
                for (int rad = 0; rad < length; rad++)
                {
                    if (board[rad][kol] != '.' && !set.Add(board[rad][kol]))
                    {
                        return false;
                    }
                }
            }
            int step = length / 3;
            //Duplikater i ruta 0,2 3,5 ,6,8
            for (int rad = 1; rad < length; rad += step)
            {
                for (int kol = 1; kol < length; kol += step)
                {
                    set.Clear();
                    for (int i = -1; i <= 1; i++)
                    {
                        for (int j = -1; j <= 1; j++)
                        {
                            if (board[rad + i][kol + j] != '.' && !set.Add(board[rad + i][kol + j]))
                            {
                                return false;
                            }
                        }
                    }
                }
            }
            return true;
        }
    }
}
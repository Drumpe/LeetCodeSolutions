namespace LeetCodeSolutions
{
    public class _374 //: GuessGame
    {
        /** 
        * Forward declaration of guess API.
        * @param  num   your guess
        * @return 	     -1 if num is higher than the picked number
        *			      1 if num is lower than the picked number
        *               otherwise return 0
        * int guess(int num);
        */
        public int GuessNumber(int n)
        {
            return guessNumber(1, n);
        }

        public int guessNumber(int from, int to)
        {
            int num = from + ((to - from) / 2);
            int ans = guess(num);
            if (ans == 0)
                return num;
            else if (ans == 1)
                return guessNumber(num + 1, to);
            else
                return guessNumber(from, num - 1);
        }
        public int guess(int num)
        {
            return 0; //Dummy function
        }
    }
}
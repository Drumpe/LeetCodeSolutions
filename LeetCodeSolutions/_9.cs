namespace LeetCodeSolutions
{
    public class _9
    {
        public static bool IsPalindrome(int x)
        {
            if (x < 0 || (x % 10 == 0 && x != 0))
            {
                return false;
            }
            int revertedNumber = 0;
            while (x > revertedNumber)
            {
                revertedNumber = revertedNumber * 10 + x % 10;
                x /= 10;
            }
            return revertedNumber == x || revertedNumber / 10 == x;

            /*
            var str = x.ToString();
            //return str == new string(str.ToCharArray().Reverse().ToArray());
            int length = str.Length;
            for (int i = 0; i < length/2; i++)
            {
                if (str[i] != str[length - i - 1])
                {
                    return false;
                }
            }
            return true;
            */
        }
    }
}
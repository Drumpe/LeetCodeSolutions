namespace LeetCodeSolutions
{
    public class _12
    {
        public string IntToRoman(int num)
        {
            int[] val = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            String[] rom = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

            string str = string.Empty;
            int i = 0;
            while (num > 0)
            {
                while (num >= val[i])
                {
                    str += rom[i];
                    num -= val[i];
                }
                i++;
            }
            return str;
        }
    }
}
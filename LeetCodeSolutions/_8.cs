namespace LeetCodeSolutions
{
    public class _8
    {
        public int MyAtoi(string s)
        {
            long result = 0;
            bool positiv = true;
            int index = 0;
            s = s.TrimStart();
            if (string.IsNullOrEmpty(s))
                return 0;
            if (s[0] is '+' or '-')
            {
                index++;
                if (s[0] is '-')
                {
                    positiv = false;
                }
            }
            while (index < s.Length && char.IsDigit(s[index]))
            {
                result = (result * 10) + int.Parse(s[index++].ToString());
                //Kolla om resultString outofbound och åt vilket håll?
                if (positiv && result > int.MaxValue)
                    return int.MaxValue;
                else if (-result < int.MinValue)
                    return int.MinValue;
            }
            return (int)(positiv ? result : -result);
        }
    }
}
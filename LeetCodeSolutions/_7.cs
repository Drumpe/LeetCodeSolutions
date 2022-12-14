namespace LeetCodeSolutions
{
    public class _7
    {
        public int Reverse(int x)
        {
            string s = x.ToString();
            string res = "";
            if (s[0] == '-')
            {

                res = '-' + reverse(s.Substring(1));
            }
            else
            {
                res = reverse(s);
            }

            return int.TryParse(res, out int num) ? num : 0;
        }

        static string reverse(string s)
        {
            string result = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                result += s[i];
            }
            return result;
        }
    }
}
namespace LeetCodeSolutions
{
    public class _13
    {
        public int RomanToInt(string s)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>
    {
        {'I', 1},
        {'V', 5},
        {'X', 10},
        {'L', 50},
        {'C', 100},
        {'D', 500},
        {'M', 1000}
    };
            int result = 0;
            for (int i = 0; i < s.Length - 1; i++)
            {
                result += dict[s[i]] < dict[s[i + 1]] ? -dict[s[i]] : dict[s[i]];
            }
            return result += dict[s[^1]];
        }
    }
}
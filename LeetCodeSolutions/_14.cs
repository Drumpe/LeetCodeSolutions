namespace LeetCodeSolutions
{
    public class _14
    {
        public static string LongestCommonPrefix(string[] strs)
        {
            int minLength = int.MaxValue;
            foreach (var str in strs)
            {
                minLength = Math.Min(minLength, str.Length);
            }
            string minPrefix = string.Empty;
            for (int i = 0; i < minLength; i++)
            {
                char currentChar = strs[0][i];
                for (int j = 1; j < strs.Length; j++)
                {
                    if (currentChar != strs[j][i])
                    {
                        return minPrefix;
                    }
                }
                minPrefix += currentChar;
            }
            return minPrefix;
        }
    }
}
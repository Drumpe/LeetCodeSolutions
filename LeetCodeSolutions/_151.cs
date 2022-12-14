namespace LeetCodeSolutions
{
    public class _151
    {
        public static string ReverseWords(string s)
        {
            var words = s.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries);
            Array.Reverse(words);
            return string.Join(" ", words).TrimEnd();
        }
    }
}
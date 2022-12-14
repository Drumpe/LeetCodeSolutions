namespace LeetCodeSolutions
{
    public class _1662
    {
        public bool ArrayStringsAreEqual(string[] word1, string[] word2) =>
            string.Join(string.Empty, word1).Equals(string.Join(string.Empty, word2));

    }
}
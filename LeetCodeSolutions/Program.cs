namespace LeetCodeSolutions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Test area:
            int[] nums = { 23, 2, 6, 4, 7 };
            int[][] matrix = new int[][] { new[] { 1, 2, 3, 4 }, new[] { 5, 1, 2, 3 }, new[] { 9, 5, 1, 2 } };

            Console.WriteLine(_151.ReverseWords("the sky is blue"));
            Console.WriteLine(_151.ReverseWords("  hello world  "));
            Console.WriteLine(_151.ReverseWords("a good   example"));

        }
    }
}
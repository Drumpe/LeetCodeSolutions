namespace LeetCodeSolutions
{
    public class _523
    {
        public static bool CheckSubarraySum(int[] nums, int k)
        {
            //Brute force gav Time Limit Exceeded
            Dictionary<int, int> dict = new Dictionary<int, int>();
            var sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                sum %= k;
                Console.WriteLine($"sum: {sum}  i: {i}");
                if (sum == 0 && i > 0)
                {
                    return true;
                }
                if (dict.ContainsKey(sum) && i - dict[sum] > 1)
                {
                    return true;
                }
                if (!dict.ContainsKey(sum))
                {
                    dict.Add(sum, i);
                }
            }
            return false;
        }
    }
}
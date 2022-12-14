namespace LeetCodeSolutions
{
    public class _55
    {
        public bool CanJump(int[] nums)
        {
            int length = nums.Length;
            int dist = 0;
            for (int i = 0; i < length; i++)
            {
                if (dist < i) return false;
                dist = Math.Max(i + nums[i], dist);
            }
            return true;
        }
    }
}
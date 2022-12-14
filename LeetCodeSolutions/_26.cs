namespace LeetCodeSolutions
{
    public class _26
    {
        public int RemoveDuplicates(int[] nums)
        {
            int pointer = 1;
            for (int current = 1; current < nums.Length; current++)
            {
                if (nums[current] != nums[current - 1])
                {
                    nums[pointer++] = nums[current];
                }
            }
            return pointer;
        }
    }
}
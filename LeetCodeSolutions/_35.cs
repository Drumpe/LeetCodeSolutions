namespace LeetCodeSolutions
{
    public class _35
    {
        public int SearchInsert(int[] nums, int target)
        {
            int low = 0;
            int high = nums.Length - 1;
            int mid = -1;
            while (low <= high)
            {
                mid = (low + high) / 2;
                if (nums[mid] == target)
                {
                    return mid;
                }
                else if (target < nums[mid])
                {
                    high = mid - 1; //sök vänster
                }
                else
                {
                    low = mid + 1; //sök höger
                }
            }
            return low;
        }
    }
}
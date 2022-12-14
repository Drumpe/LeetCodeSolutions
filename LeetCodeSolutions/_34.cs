namespace LeetCodeSolutions
{
    public class _34
    {
        public int[] SearchRange(int[] nums, int target)
        {
            int[] result = new int[2];
            result[0] = BS_F(nums, target);
            result[1] = BS_L(nums, target);
            return result;
        }
        //Binary search - find first
        public int BS_F(int[] nums, int target)
        {
            int low = 0;
            int high = nums.Length - 1;
            int mid = -1;
            int res = -1;
            while (low <= high)
            {
                mid = (low + high) / 2;
                if (nums[mid] == target)
                {
                    res = mid;
                    high = mid - 1; //Finns det en som har lägre index?
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
            return res;
        }
        //Binary search - find last
        public int BS_L(int[] nums, int target)
        {
            int low = 0;
            int high = nums.Length - 1;
            int mid = -1;
            int res = -1;
            while (low <= high)
            {
                mid = low + (high - low) / 2;
                if (nums[mid] == target)
                {
                    res = mid;
                    low = mid + 1; //Finns det en som har högre index?
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
            return res;
        }
    }
}
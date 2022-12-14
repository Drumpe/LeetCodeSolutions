namespace LeetCodeSolutions
{
    public class _33
    {
        public int Search(int[] nums, int target)
        {
            //return Array.IndexOf(nums, target);
            int low = 0;
            int high = nums.Length - 1;
            int mid = -1;
            while (low <= high)
            {
                mid = low + (high - low) / 2;
                if (nums[mid] == target)
                {
                    return mid;
                }
                if (nums[low] <= nums[mid]) //Vänster sorterad
                {
                    if (target < nums[mid])
                    {
                        high = mid - 1; //sök vänster
                    }
                    else
                    {
                        low = mid + 1; //sök höger
                    }
                }
                else //Höger sorterad
                {
                    if (nums[mid] < target && target <= nums[high])
                    {
                        low = mid + 1; //sök höger
                    }
                    else
                    {
                        high = mid - 1; //sök vänster
                    }
                }
            }
            return -1; //Inte hittad
        }
    }
}
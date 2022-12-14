namespace LeetCodeSolutions
{
    public class _4
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            double median = 0;
            int totLength = nums1.Length + nums2.Length;
            int[] nums = new int[totLength];

            //int i = 0;
            ////concat arrays
            //while (i < nums1.Length)
            //{
            //    nums[i] = nums1[i];
            //    i++;
            //}
            //while (i < totLength)
            //{
            //    nums[i] = nums2[i - nums1.Length];
            //    i++;
            //}
            //Array.Sort(nums); // Sortera nums

            //Sortera direkt
            int j = 0; //nums1 index
            int k = 0; //nums2 index
            for (int i = 0; i < totLength; i++)
            {
                if (nums1.Length == j)
                {
                    nums[i] = nums2[k++];
                }
                else if (nums2.Length == k)
                {
                    nums[i] = nums1[j++];
                }
                else if (nums1[j] < nums2[k])
                {
                    nums[i] = nums1[j++];
                }
                else
                {
                    nums[i] = nums2[k++];
                }
            }
            if (nums.Length % 2 == 0)
            {
                median = (nums[nums.Length / 2] + nums[(nums.Length / 2) - 1]) / 2.0;
            }
            else
            {
                median = nums[nums.Length / 2];
            }
            return median;
        }
    }
}
namespace LeetCodeSolutions
{
    public class _15 //Time Limit Exceeded!
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            //Måste göras på effektivare sätt 
            IList<IList<int>> result = new List<IList<int>>();
            HashSet<string> set = new HashSet<string>();
            for (int i = 0; i < nums.Length - 2; i++)
            {
                for (int j = i + 1; j < nums.Length - 1; j++)
                {
                    for (int k = j + 1; k < nums.Length; k++)
                    {
                        if (nums[i] + nums[j] + nums[k] == 0)
                        {
                            List<int> triplet = new List<int>() { nums[i], nums[j], nums[k] };
                            triplet.Sort();
                            if (set.Add(string.Join("", triplet)))
                                result.Add(triplet);
                        }
                    }
                }
            }
            return result;
        }
    }
}
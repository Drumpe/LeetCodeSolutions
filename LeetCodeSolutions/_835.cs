namespace LeetCodeSolutions
{
    public class _835
    {
        //Förstår inte denna, men implementerar den ändå.
        //Brute force fick jag inte till att fungera.
        public int LargestOverlap(int[][] img1, int[][] img2)
        {
            int length = img1.Length;
            List<int> list1 = new List<int>();
            List<int> list2 = new List<int>();
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < length * length; i++)
            {
                if (img1[i / length][i % length] == 1)
                {
                    list1.Add(i / length * 100 + i % length);
                }
                if (img2[i / length][i % length] == 1)
                {
                    list2.Add(i / length * 100 + i % length);
                }
            }
            foreach (var item1 in list1)
            {
                foreach (var item2 in list2)
                {
                    if (dict.ContainsKey(item1 - item2))
                    {
                        dict[item1 - item2]++;
                    }
                    else
                    {
                        dict.Add(item1 - item2, 1);
                    }
                }
            }
            int result = 0;
            foreach (var item in dict.Values)
            {
                result = Math.Max(result, item);
            }
            return result;
        }
    }
}
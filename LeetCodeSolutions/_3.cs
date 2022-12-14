namespace LeetCodeSolutions
{
    public class _3
    {
        public int LengthOfLongestSubstring(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }
            HashSet<char> hSet = new HashSet<char>();
            int max = 0;
            int i = 0;
            int j = 0;
            while (i < s.Length)
            {
                if (!hSet.Contains(s[i]))   // Inte med i set
                {
                    hSet.Add(s[i]);         //Lägg till i set
                    i++;

                }
                else                                    //Med i set
                {
                    max = Math.Max(max, hSet.Count);    //Max av max och storleken på set
                    hSet.Remove(s[j]);                  //Tabort från set
                    j++;
                }
            }
            max = Math.Max(max, hSet.Count);
            return max;
        }
    }
}
namespace LeetCodeSolutions
{
    public class _49
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            Dictionary<string, IList<string>> dict = new Dictionary<string, IList<string>>();
            for (int i = 0; i < strs.Length; i++)
            {
                var chars = strs[i].ToCharArray();
                Array.Sort(chars);
                string sortedString = new string(chars);
                if (dict.ContainsKey(sortedString))
                {
                    dict[sortedString].Add(strs[i]);
                }
                else
                {
                    dict.Add(sortedString, new List<string>() { strs[i] });
                }
            }
            IList<IList<string>> result = new List<IList<string>>();
            foreach (var item in dict)
            {
                result.Add(item.Value);
            }
            return result;
        }
        public IList<IList<string>> GroupAnagramsUsingPrimes(string[] strs)
        {
            //Funkar inte hela vägen
            ulong modulatorNummer = 18446744073709551557;
            ulong[] primes = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97, 101 };
            Dictionary<ulong, IList<string>> dict = new Dictionary<ulong, IList<string>>();
            foreach (var str in strs)
            {
                ulong key = 1;
                foreach (var c in str)
                {
                    key *= primes[c - 'a'];
                    key %= modulatorNummer;
                }
                if (dict.ContainsKey(key))
                {
                    dict[key].Add(str);
                }
                else
                {
                    dict.Add(key, new List<string>() { str });
                }
            }
            IList<IList<string>> result = new List<IList<string>>();
            foreach (var item in dict)
            {
                result.Add(item.Value);
            }
            return result;
        }
    }
}
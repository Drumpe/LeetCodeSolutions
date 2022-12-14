namespace LeetCodeSolutions
{
    public class _433
    {
        public int MinMutation(string start, string end, string[] bank)
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue(start);
            HashSet<string> visited = new HashSet<string>();
            visited.Add(start);
            int steps = 0;
            char[] chars = { 'A', 'C', 'G', 'T' };
            while (queue.Count != 0)
            {
                for (int i = queue.Count; i > 0; i--)
                {
                    string str = queue.Dequeue();
                    if (str.Equals(end))
                    {
                        return steps;
                    }
                    char[] charArray = str.ToCharArray();
                    for (int j = 0; j < 8; j++)
                    {
                        char orginalChar = charArray[j];

                        foreach (var c in chars)
                        {
                            charArray[j] = c;
                            string s = new string(charArray);
                            if (!visited.Contains(s) && bank.Contains(s))
                            {
                                queue.Enqueue(s);
                                visited.Add(s);
                            }
                        }
                        charArray[j] = orginalChar;
                    }
                }
                steps++;
            }
            return -1;
        }
    }
}
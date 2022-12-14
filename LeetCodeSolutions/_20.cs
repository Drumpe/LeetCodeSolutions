namespace LeetCodeSolutions
{
    public class _20
    {
        public bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();
            foreach (char c in s)
            {
                if (c == '(')
                {
                    stack.Push(')');
                }
                else if (c == '{')
                {
                    stack.Push('}');
                }
                else if (c == '[')
                {
                    stack.Push(']');
                }
                else if (stack.Count == 0 || c != stack.Pop())
                {
                    return false;
                }
            }
            return stack.Count == 0;
        }
    }
}
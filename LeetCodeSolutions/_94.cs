namespace LeetCodeSolutions
{
    public class _94
    {
        private IList<int> list = new List<int>();

        public IList<int> InorderTraversal(TreeNode root)
        {
            if (root == null)
                return list;

            InorderTraversal(root.left);
            list.Add(root.val);
            InorderTraversal(root.right);

            return list;
        }
    }
}
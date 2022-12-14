namespace LeetCodeSolutions
{
    public class _2
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var last = new ListNode();
            var resultList = last;
            var carry = 0;
            var sum = 0;
            while (l1 != null || l2 != null)
            {
                if (l1 == null)
                {
                    sum = l2.val;
                }
                else if (l2 == null)
                {
                    sum = l1.val;
                }
                else
                {
                    sum = l1.val + l2.val;
                }
                last.val = (sum + carry) % 10;
                carry = (sum + carry) / 10;
                if (l1 != null)
                {
                    l1 = l1.next;
                }
                if (l2 != null)
                {
                    l2 = l2.next;
                }
                if (!(l1 == null && l2 == null))
                {
                    last.next = new ListNode();
                    last = last.next;
                }
            }
            if (carry == 1)
                last.next = new ListNode(1);

            return resultList;
        }
    }
}
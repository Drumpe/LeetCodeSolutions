namespace LeetCodeSolutions
{
    public class _21I
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            if (list1 == null)
            {
                return list2;
            }
            if (list2 == null)
            {
                return list1;
            }
            ListNode result = null;
            if (list1.val < list2.val)
            {
                result = list1;
                list1 = list1.next;
            }
            else
            {
                result = list2;
                list2 = list2.next;
            }
            ListNode pointer = result;
            while (list1 != null && list2 != null)
            {
                if (list1.val < list2.val)
                {
                    pointer.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    pointer.next = list2;
                    list2 = list2.next;
                }
                pointer = pointer.next;
            }
            if (list1 == null)
            {
                pointer.next = list2;
            }
            else
            {
                pointer.next = list1;
            }
            return result;
        }
    }
}
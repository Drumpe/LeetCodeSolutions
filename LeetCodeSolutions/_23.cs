namespace LeetCodeSolutions
{
    public class _23
    {
        public ListNode MergeKLists(ListNode[] lists)
        {
            if (lists.Length == 0)
            {
                return null;
            }
            if (lists.Length == 1)
            {
                return lists[0];
            }

            ListNode resultList = MergeTwoLists(lists[0], lists[1]);
            for (int i = 2; i < lists.Length; i++)
            {
                resultList = MergeTwoLists(resultList, lists[i]);
            }
            return resultList;
        }
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
            if (list1.val < list2.val)
            {
                list1.next = MergeTwoLists(list1.next, list2);
                return list1;
            }
            list2.next = MergeTwoLists(list1, list2.next);
            return list2;
        }
    }
}
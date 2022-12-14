namespace LeetCodeSolutions
{
    public class _19
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            ListNode pointer = head;
            //Räkna antalet noder
            var antalNoder = 0;
            while (pointer != null)
            {
                pointer = pointer.next;
                antalNoder++;
            }
            //Om vi tar bort första noden
            if (antalNoder - n == 0)
                return head.next;
            pointer = head; //Nollställ pointer
                            //Stega fram till n-1 
            for (int i = 1; i < antalNoder - n; i++)
                pointer = pointer.next;
            pointer.next = pointer.next.next;

            return head;
        }

    }
}
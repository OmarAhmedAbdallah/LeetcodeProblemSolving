using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems._876._Middle_of_the_Linked_List
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    internal class MiddleNodeClass
    {
        public ListNode MiddleNode(ListNode head)
        {
            ListNode? slow = head;
            ListNode? fast = head.next;

            while (fast is not null)
            {
                slow = slow.next;
                fast = fast.next?.next;
            }

            return slow;
        }
    }
}

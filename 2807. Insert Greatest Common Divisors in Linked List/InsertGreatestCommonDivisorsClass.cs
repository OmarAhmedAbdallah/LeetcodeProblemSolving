using LeetCodeProblems._876._Middle_of_the_Linked_List;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems._2807._Insert_Greatest_Common_Divisors_in_Linked_List
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
    internal class InsertGreatestCommonDivisorsClass
    {
        public ListNode InsertGreatestCommonDivisors(ListNode head)
        {
            if (head.next == null)
            {
                return head;
            }

            var currNode = head;

            while(currNode.next != null)
            {
                var a = currNode.next.val;
                var b = currNode.val;

                var gcd = GCD(a, b);

                var newNode = new ListNode(gcd,currNode.next);
                currNode.next = newNode;

                currNode = newNode.next;
            }

            return head;
        }

        int GCD(int a ,int b)
        {
            if (a < b)
            {
                int temp = a;
                a = b;
                b = temp;
            }

            while (b != 0)
            {
                var temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
    }
}

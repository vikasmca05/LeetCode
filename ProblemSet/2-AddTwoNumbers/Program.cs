using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_2_AddTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();

            ListNode L1 = new ListNode(2);
            L1.next = new ListNode(4);
            L1.next.next = new ListNode(3);

            Console.WriteLine("First Input Linked List \n");
            s.printListNode(L1);

            ListNode L2 = new ListNode(5);
            L2.next = new ListNode(6);
            L2.next.next = new ListNode(4);
            Console.WriteLine("Second Input Linked List \n");
            s.printListNode(L2);

            int response = s.AddTwoListNodes(L1, L2);
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    public class Solution
    {
        public int AddTwoListNodes(ListNode l1, ListNode l2)
        {
            //Reverse the linked list
            int i1 = ReverseLinkedList(l1);
            int i2 = ReverseLinkedList(l2);

            //Add linked list
            int iResult = i1 + i2;
            int iSample = iResult;
            int offset = 0;
            ListNode lResult = null;
            ListNode headNode = null;
            ListNode lastNode = null;

            while (iResult > 0)
            {

                int iTemp = iResult % 10;
                if (lResult == null)
                {
                    lResult = new ListNode(iTemp);
                    if (headNode == null)
                        headNode = lResult;
                    if (lastNode != null)
                    {
                        lastNode.next = lResult;
                    }
                }
                    lastNode = lResult;
                    lResult = lResult.next;
                     
                iResult /= 10;
              
            }
            Console.WriteLine("Output Linked List \n");
            printListNode(headNode);

            return 0;
        }

        public int ReverseLinkedList(ListNode l1)
        {
            if (l1 == null)
                return 0;
            if (l1.next == null)
                return l1.val;

            ListNode prev = null;
            ListNode current = l1;
            ListNode next = null;
            int sum = 0;
            int offset = 1;

            while(current != null)
            {
                sum = current.val * (offset) + sum;
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;
                offset = offset * 10;
            }

            l1 = prev;

            Console.WriteLine("Reversed Linked List \n");
            printListNode(l1);
     
            return sum;
        }

        /* Function to print linked list */
        public void printListNode(ListNode l1)
        {
        ListNode temp = l1; 
        while (temp != null) 
        { 
            Console.WriteLine (temp.val); 
            temp = temp.next; 
            
        }
} 
    }
}

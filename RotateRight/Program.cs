using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateRight
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
  
    public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
          this.val = val;
          this.next = next;
      }
  }
    public class Solution
    {
        public ListNode RotateRight(ListNode head, int k)
        {
            if (head == null)
                return head;
            ListNode curr = head;
            int len = 1;
            while (curr.next != null)
            {
                curr = curr.next;
                len++;
            }
            curr.next = head;
            curr = curr.next;
            int end = len - k % len;
            for (int i = 1; i < end; i++)
                curr = curr.next;
            ListNode ans = curr.next;
            curr.next = null;
            return ans;
        }
    }
}

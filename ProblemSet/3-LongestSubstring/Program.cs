using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_LongestSubstring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string sLine = Console.ReadLine();
            Solution s = new Solution();
           
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
        public int ReadChar(string input)
        {
            char[] b = new char[input.Length + 1];
            char prev;
            char current;
            for (int i=0;i<input.Length;i++)
            {
                prev = char[i];
            }
            return 0;
        }
    }
}
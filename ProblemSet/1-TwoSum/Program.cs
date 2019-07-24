using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_1_TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            TwoSum s = new TwoSum();

            Console.WriteLine("Please Enter 10 int numbers");
            int[] nums = new int[10];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = Convert.ToInt32( Console.ReadLine());
            }
            //int[] nums = { 1, 4, 5, 8, 3, 2, 11, 13 };

            Console.WriteLine("Please Enter Target Sum");
            int Target = Convert.ToInt32(Console.ReadLine());

            //int Target = 15;

            int[] response = s.GetTarget(nums, Target);
            if (response == null)
                return;

            Console.WriteLine("Final Target Sum found with value of indices, as per question ");
            foreach (int var in response)
                Console.WriteLine(var);

            return;
        }
    }

    class TwoSum
    {
        public int[] GetTarget(int[] nums,int Target)
        {
            if (nums.Length == 0)
                return null;
            int[] response = new int[2];
            for(int i=0;i<nums.Length;i++)
            {
                int firstNumber = nums[i];
                for(int s=0;s<i;s++)
                {
                    if (i == s)
                        continue;
                    if (firstNumber + nums[s] == Target)
                    {
                        Console.WriteLine("Target Sum found with value of indices ");
                        Console.WriteLine(i);
                        Console.WriteLine(s);
                        response[0] = i;
                        response[1] = s;
                    }

                }

            }
            return response;
        }

    }
}

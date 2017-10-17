using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dedupe
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[5000];
            Random rnd = new Random();

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = rnd.Next(1, 50);
            }

            Array.Sort(nums);

            for (int i = 0; i < nums.Length-1; i++)
            {
                for (int j = i+1; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        nums[j] = -1;
                    }
                }
            }
            int length = 0;
            foreach (int n in nums)
            {
                if (n != -1)
                {
                    length++;
                }
            }
            Console.WriteLine(length);
        }
    }
}

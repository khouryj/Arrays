using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[50];
            Random rnd = new Random();
            bool unique;

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = rnd.Next(1, 50);
            }

            for (int i = 0; i < nums.Length-1; i++)
            {
                unique = true;
                for (int j = i+1; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        unique = false;
                    }
                }
                for (int j = nums.Length-1; j > nums[i]; j--)
                {
                    if (nums[i] == nums[j])
                    {
                        unique = false;
                    }
                }
                if (unique)
                {
                    Console.WriteLine(nums[i]);
                }
            }
        }
    }
}

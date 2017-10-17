using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMax
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[50];
            Random rnd = new Random();

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = rnd.Next(1, 50);
            }

            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i]);
                if (i == 9 || i == 19 || i == 29 || i == 39 || i == 49)
                {
                    Console.Write("\n");
                }
                else
                {
                    Console.Write(",");
                }
            }

            int min = nums[0], max = 0;

            for (int i = 0; i < nums.Length; i++)
            {
               if (nums[i] > max)
               {
                    max = nums[i];
               }
               if (nums[i] < min)
               {
                    min = nums[i];
               }
            }

            Console.WriteLine("Min: " + min + "\nMax: " + max);
        }
    }
}

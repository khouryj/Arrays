using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayFizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] arr = new String[100];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i + ". ";
                if (i % 3 == 0)
                {
                    arr[i] += "Fizz";
                }
                if (i % 5 == 0)
                {
                    arr[i] += "Buzz";
                }
            }
            foreach (String s in arr)
            {
                Console.WriteLine(s);
            }
        }
    }
}

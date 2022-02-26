using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {                                           //6#
            List<int> num = Console.ReadLine()
               .Split(' ')
               .Select(int.Parse)
               .Reverse()
               .ToList();

            List<int> num1 = new List<int>();
            foreach (var nums in num)
            {
                if (nums > 0)
                {
                    num1.Add(nums);
                }
            }
            if (num1.Count < 1)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", num1));
            }
        }
    }
}

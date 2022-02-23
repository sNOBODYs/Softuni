using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write the numbers here ->");

            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Console.WriteLine();
            Console.Write("What's the sum? ->");

            int sumOfNumbers = int.Parse(Console.ReadLine());

            Console.WriteLine();

            int firstNum = 0;
            int secondNum = 0;

            for (int i = -1; i < numbers.Length; i++)
            {
                if (numbers[i] + numbers[i+1] == sumOfNumbers )
                {
                    firstNum = i;
                    secondNum = i + 1;
                    Console.WriteLine($"{firstNum} {secondNum}");
                }
               
            }

        }
    }
}

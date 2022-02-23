using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToArray();

           
            int currentIndex = -1;
            int count = 1;

            
            int maxCount = 1;
            int leftIndex = -1;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                
                int currentNumber = numbers[i];
                int nextNumber = numbers[i + 1];

               
                if (currentNumber == nextNumber)
                {
                    count++;
                    currentIndex = i + 1;
                }
                else
                {
                    count = 1;
                }

                
                if (maxCount < count)
                {
                    leftIndex = currentIndex;
                    maxCount = count;
                }
            }
            leftIndex = leftIndex - maxCount + 1;
            for (int i = leftIndex; i < leftIndex + maxCount; i++)
            {
                Console.Write(numbers[i] + " ");
            }
        }
    }
}

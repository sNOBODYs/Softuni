using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            int winnerSequence = 0;
            int winnerIndex = 0;
            int winnerSum = 0;
            int winnerSample = 0;
            int sampleCount = 0;

            string input;

            int n = int.Parse(Console.ReadLine());
            int[] bestArray = new int[n];

            while ((input = Console.ReadLine()) != "Clone them!")
            {
                int[] dna = input
                    .Split("!".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                sampleCount++;

                int sum = 0;
                int curStart = -1;
                int curLength = 0;
                int currentPositionMax = -1;
                int currentLengthMax = 0;
                for (int i = 0; i < dna.Length; i++)
                {
                    if (dna[i] == 1)
                    {
                        if (curStart == -1)
                        {
                            curStart = i;
                        }
                        sum++;
                        curLength++;
                    }
                    if (dna[i] == 0 || i == dna.Length - 1)
                    {
                        if (curLength > currentLengthMax)
                        {
                            currentLengthMax = curLength;
                            currentPositionMax = curStart;
                        }
                        curLength = 0;
                        curStart = -1;
                    }
                }
            }
        }
    }
}
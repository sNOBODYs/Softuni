using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bestDna = null;
            int bestLen = -1;
            int startIndex = -1;
            int bestDnaSum = 0;
            int bestSampleIndex = 0;

            int currentSampleIndex = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Clone them!")
                {
                    break;
                }

                string[] currentDna = input.Split('!');
                int currentLen = 0;
                int currentBestLen = 0;
                int currentEndIndex = 0;

                for (int i = 0; i < currentDna.Length; i++)
                {
                    if (currentDna[i] == "1")
                    {
                        currentLen++;
                        if (currentLen > currentBestLen)
                        {
                            currentEndIndex = i;
                            currentBestLen = currentLen;
                        }
                    }
                    else
                    {
                        currentLen = 0;
                    }
                }

                int currentStartIndex = currentEndIndex - currentBestLen + 1;


            }
        }
    }
}

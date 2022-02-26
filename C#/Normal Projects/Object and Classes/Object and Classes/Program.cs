using System;
using System.Linq;

namespace Object_and_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var wordsList = Console.ReadLine()
                .Split(' ')
                .ToList();
            var wordsCount = wordsList.Count;
            for (int i = 0; i < wordsCount - 1; i++)
            {
                int j = random.Next(0, wordsCount);
                if (i != j)
                {
                    var old = wordsList[i];
                    wordsList[i] = wordsList[j];
                    wordsList[j] = old;
                }
            }

            foreach (var word in wordsList)
            {
                Console.WriteLine(word);
            }
        }
    }
}

using System;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            Console.WriteLine(Repeater(words));
        }

        static string Repeater(string[] words)
        {
            StringBuilder newWord = new StringBuilder();

            foreach (var word in words)
            {
                foreach (char ch in word)
                {
                    newWord.Append(word);
                }
            }

            return newWord.ToString();
        }
    }
}

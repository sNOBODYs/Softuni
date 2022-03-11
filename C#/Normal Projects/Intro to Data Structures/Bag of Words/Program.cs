using System;
using Wintellect.PowerCollections;

namespace Bag_of_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderedBag<string> bag = new OrderedBag<string>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                bag.Add(word);
            }

            foreach (var element in bag)
            {
                Console.WriteLine(element);
            }
        }
    }
}

using System;

namespace Final_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Competitor<int> IvanTheWiner = new Competitor<int>("Ivan", 16);
            IvanTheWiner.Add(6);
            IvanTheWiner.Add(2);
            IvanTheWiner.Add(5);
            IvanTheWiner.Add(4);
            foreach (var scores in IvanTheWiner)
            {
                Console.WriteLine(scores);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            SortedDictionary<string, int> symbols = new SortedDictionary<string, int>();

            foreach (var word in input)
            {
                if (symbols.ContainsKey(word))
                {
                    symbols[word]++;
                }
                else
                {
                    symbols[word] = 1;
                }
            }

            foreach (var symbol in symbols)
            {
                Console.WriteLine("{0} -> {1}", symbol.Key, symbol.Value);
            }
        }
    }
}

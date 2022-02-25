using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {                                              //6#
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "end")
                {
                    break;
                }
                string[] tokens = line.Split();

                switch (tokens[0])
                {
                    case "Add":
                        int numberAdd = int.Parse(tokens[1]);
                        numbers.Add(numberAdd);
                        break;
                    case "Remove":
                        int numberRemove = int.Parse(tokens[1]);
                        numbers.Remove(numberRemove);
                        break;
                    case "RemoveAt":
                        int removeAt = int.Parse(tokens[1]);
                        numbers.RemoveAt(removeAt);
                        break;
                    case "Insert":
                        int num = int.Parse(tokens[1]);
                        int index = int.Parse(tokens[2]);
                        numbers.Insert(index, num);
                        break;
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}

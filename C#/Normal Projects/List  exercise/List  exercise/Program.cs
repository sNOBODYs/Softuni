using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List__exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int max = int.Parse(Console.ReadLine());

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "end")
                {
                    break;
                }

                string[] commandAndValue = line.Split();

                if (commandAndValue[0] == "Add")
                {
                    list.Add(int.Parse(commandAndValue[1]));
                }
                else
                {
                    
                    for (int i = 0; i < list.Count; i++)
                    {
                        int sum = list[i] + int.Parse(commandAndValue[0]);
                        if (max >= sum)
                        {
                            list.RemoveAt(i);
                            list.Insert(i, sum);
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" " , list));
        }
    }
}

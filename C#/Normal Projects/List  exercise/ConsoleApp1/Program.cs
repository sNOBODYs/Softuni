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
            List<int> list = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "End")
                {
                    break;
                }
                string[] commandAndValue = line.Split();

                switch (commandAndValue[0])
                {
                    case "Add":
                        list.Add(int.Parse(commandAndValue[1]));
                        break;
                    case "Insert":
                        list.Insert(int.Parse(commandAndValue[2]), int.Parse(commandAndValue[1]));
                        break;
                    case "Remove":
                        list.RemoveAt(int.Parse(commandAndValue[1]));
                        break;
                    case "Shift":
                        if (commandAndValue[1] == "right")
                        {
                            int turn = int.Parse(commandAndValue[2]);
                            for (int i = 0; i < turn; i++)
                            {
                                list.Insert(0,list.Count - 1);
                                list.RemoveAt(list.Count - 1);
                            }
                        }
                        else if (commandAndValue[1] == "left")
                        {
                            int turn = int.Parse(commandAndValue[2]);
                            for (int i = 0; i < turn; i++)
                            {
                                list.Add(list[0]);
                                list.RemoveAt(0);
                            }
                        }
                         
                        break;
                }
            }
            Console.WriteLine(string.Join(" ", list));
        }
    }
}


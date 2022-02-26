using System;
using System.Linq;

namespace Newspapper
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(",").ToArray();
            string title = input[0];
            string text = input[1];
            string writer = input[2];

            News news = new News(title, text, writer);

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] commandPlusInput = Console.ReadLine().Split(": ");
                string command = commandPlusInput[0];

                if (command == "Edit")
                {
                    news.Edit(commandPlusInput[1]);
                }
                else if (command == "ChangeWriter")
                {
                    news.ChangeWriter(commandPlusInput[1]);
                }
                else if (command == "Rename")
                {
                    news.Rename(commandPlusInput[1]);
                }
            }
            Console.WriteLine(news.ToString());
        }
    }
}

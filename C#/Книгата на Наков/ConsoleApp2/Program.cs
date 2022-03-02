using System;
using System.Text;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string remove = Console.ReadLine();
            StringBuilder removeHere = new StringBuilder(Console.ReadLine());

            while (removeHere.ToString().Contains(remove))
            {
                removeHere.Replace(remove.ToLower(), "");
            }
            Console.WriteLine(removeHere);
        }
    }
}

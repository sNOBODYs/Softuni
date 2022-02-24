using System;

namespace Drwaing_with_loops_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.Write("{0}{0}{1}{0}{0}", new string('*', n), new string(' ', n), new string('*', n));
            Console.WriteLine();
            for (int i = 1; i < n - 1; i++)
            {
                Console.Write("*");
                for (int y = 0; y < (n * 2) - 2; y++) 
                {
                    Console.Write("/");
                }
                Console.Write("*");

                if (i == Math.Ceiling((double)(n - 2) / 2)) { Console.Write(new string('|', n)); }
                else { Console.Write(new string(' ', n)); }

                Console.Write("*");                                  
                for (int y = 0; y < (n * 2) - 2; y++)
                {
                    Console.Write("/");
                }
                Console.Write("*");
                Console.WriteLine();

            }

            Console.Write("{0}{0}{1}{0}{0}", new string('*', n), new string(' ', n), new string('*', n));
            Console.WriteLine();
        }
    }
}


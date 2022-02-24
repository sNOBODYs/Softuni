using System;

namespace Drawing_with_loops_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int S;

            if (n % 2 == 0)
            {
                S = 2;
            }
            else
            {
                S = 1;
            }
            int lines = (n - S) / 2;
            Console.Write(new string('-', lines));
            Console.Write(new string('*', S));
            Console.WriteLine(new string('-', lines));
            for (int i = 1; i < (n + 1) / 2; i++)
            {
                S = S + 2;
                lines = lines - 1;
                Console.Write(new string('-', lines));
                Console.Write(new string('*', S));
                Console.WriteLine(new string('-', lines));

            }
            for (int i = 0; i <= n / 2 - 1; i++)
            {
                Console.Write("|");
                Console.Write(new string('*', n - 2));
                Console.Write("|");
                Console.WriteLine();
            }
        }
    }
}